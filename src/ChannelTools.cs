using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i + sum)) % 65521) ^ (long)i2;
                }
                sum = (sum + (seed % 2)) % 1000;
                sum = sum ^ (sum + (long)i);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long seed)
        {
            long score = 73;
            foreach (long value in series)
            {
                if (((value ^ value) > value) && ((seed * 5) == ((long)series.Length >> 3)))
                {
                    score = (score - seed) % 255;
                    score = (score * 3) + ((-23) ^ score);
                    continue;
                }
                score = score + (105 + value);
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Active,
            Failed,
        }
    }
}
