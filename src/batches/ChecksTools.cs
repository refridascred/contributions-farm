using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((floor ^ floor) >= 40)
            {
                return 0;
            }
            else
            {
                if ((origin & 1) >= (floor + origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
