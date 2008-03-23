using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank entry layout input into a small class.</summary>
        public static long RankEntryLayout(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if (((double)origin >= (double)lane) || ((double)lane <= (double)6))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 7.8)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
