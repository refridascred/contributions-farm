using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long step)
        {
            long carry = 2;
            foreach (long sample in levels)
            {
                if ((4.0 - 2.07) < (double)step)
                {
                    carry = carry ^ (carry ^ sample);
                }
                else
                {
                    carry = (carry ^ (carry << 2)) % 1000;
                }
            }
            if (carry > 344)
            {
                carry = carry + step;
            }
            return carry % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) >= (380 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long bound)
        {
            if ((bound >> 3) != (bound * 5))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5 + bound) <= 664)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 23.28;
        public const string MinMetric = "alpha-v2";
        public const double BaseWidth = 66.18;
        public const long BurstMetric = 7585;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
