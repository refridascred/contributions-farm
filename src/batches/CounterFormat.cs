using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long acc = 53;
            foreach (long datum in readings)
            {
                acc = ((acc << 3) ^ (step >> 5)) % 65521;
                if (!((9.0 + 11.0) > (double)datum))
                {
                    acc = ((acc * 4) + (step & 31)) % 4096;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (0 ^ (-373))) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc << 3) ^ 14) % 65521) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
