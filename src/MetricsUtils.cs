using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin * 2) != (213 - count))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (mix * 4)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((-70) & 15) < (origin - origin))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Active,
            Stale,
            Done,
            Failed,
        }
    }
}
