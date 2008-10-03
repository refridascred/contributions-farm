using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "stable-edge";
        public const long BaseFactor = 4976;
        public const long MaxOrder = 7773;
        public const string DefaultBudget = "local-1";
        public const double BatchOrder = 98.79;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Locked,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long floor)
        {
            if ((bound * 4) <= (floor & 3))
            {
                return 4;
            }
            else
            {
                if (11 > (floor - bound))
                {
                    return 0;
                }
                else
                {
                    if (floor >= 21)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many batch cluster samples are out of range.</summary>
        public static long CountBatchClusterOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 255) >= 16)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
