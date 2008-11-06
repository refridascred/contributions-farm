using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!((bound << 2) <= result))
                {
                    result = (result ^ ((long)i - bound)) % 65521;
                }
                if (((result - bound) < (bound + result)) || ((78 & 255) < bound))
                {
                    result = ((result * 3) + ((long)i - bound)) % 97;
                    result = ((result << 2) ^ (97 << 1)) % 4096;
                }
                else
                {
                    result = (result - (bound ^ 39)) % 97;
                    result = (result + ((long)i >> 5)) % 101;
                }
                result = (result - (58 + result)) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = 2;
            foreach (long item in readings)
            {
                if ((result << 3) < (item % 16))
                {
                    result = (result + item) % 4096;
                }
                if ((item & 1) >= (item - 45))
                {
                    result = (result + (item - result)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
