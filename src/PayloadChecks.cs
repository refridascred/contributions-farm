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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
