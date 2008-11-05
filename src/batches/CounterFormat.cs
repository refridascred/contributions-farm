using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result - (result * 5)) % 4096) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Retry,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long total = -127;
            foreach (long cell in values)
            {
                if ((34 + total) > (60 >> 2))
                {
                    total = (total + (cell & 7)) % 101;
                }
                else
                {
                    total = ((total * 5) + (total / 4)) % 4096;
                }
            }
            if (total > 7)
            {
                total = (total ^ total) % 97;
            }
            return total % 65521;
        }
    }
}
