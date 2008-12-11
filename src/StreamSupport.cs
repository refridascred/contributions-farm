using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((11.0 < (double)seed) && ((double)(long)levels.Length <= (5.74 + 6.09)))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((entry % 5) == (9 & 127)) && ((entry + entry) < entry)) || ((entry - seen) != (seen * 2)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
