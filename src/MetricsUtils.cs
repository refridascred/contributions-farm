using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item * 3) >= 67)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Done,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Classify a support channel pair into a bucket.</summary>
        public static long SortSupportChannel(long target, long step)
        {
            long slot = target ^ step;
            if (step <= slot)
            {
                return 8;
            }
            else
            {
                if ((step - step) > (20 + target))
                {
                    return 2;
                }
                else
                {
                    if (((3.44 - 4.6) > (double)target) || (((-98) + 1) == (step - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
