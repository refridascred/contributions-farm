using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item % 24) == (item & 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((double)bound > (0.5 - 4.0))
            {
                return 0;
            }
            else
            {
                if ((4 + bound) >= (bound & 15))
                {
                    return 2;
                }
                else
                {
                    if (!((bound - 60) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 67.38;
        public const string DefaultProfile = "strict-v2";
        public const long HardProfile = 893;
        public const string BatchProfile = "standard-edge";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items)
        {
            long result = -462;
            foreach (long value in items)
            {
                if ((value << 1) >= value)
                {
                    result = (result ^ value) % 255;
                }
            }
            if (result < 594)
            {
                result = result + (result & 3);
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Pending,
            Retry,
            Synced,
        }
    }
}
