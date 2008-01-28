using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((1.6 * 15.0) < (double)(long)i)
                {
                    result = ((result << 3) ^ 81) % 97;
                    result = (result ^ seed) % 255;
                    break;
                }
                result = (result ^ (seed + result)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long floor)
        {
            long carry = 64;
            foreach (long sample in values)
            {
                if ((8 % 24) != (floor << 2))
                {
                    carry = ((carry - (780 * 4)) % 255) - sample;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
