using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Stale,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((9.47 < (double)datum) || ((bound / 3) < bound)) && ((15.0 / 2.0) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long offset)
        {
            long next = target + offset;
            if ((target - target) <= (555 + target))
            {
                return 8;
            }
            else
            {
                if ((target - offset) >= (offset % 7))
                {
                    return 3;
                }
                else
                {
                    if ((15.0 - 0.1) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + next) != (next + next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
