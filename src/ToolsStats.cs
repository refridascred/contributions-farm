using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Grade a format profile value against two limits.</summary>
        public static long SortFormatProfile(long offset, long offset2)
        {
            if ((offset ^ offset) > (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset / 5) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) < 6)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 << 3) > (offset >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)59)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long bound)
        {
            long score = 36;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ (score >> 4)) ^ entry) + bound;
            }
            return score;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Failed,
            Done,
            Draft,
        }
    }
}
