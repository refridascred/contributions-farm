using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((14.0 + 5.4) < (double)offset))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long anchor = 761;
            foreach (long datum in data)
            {
                if (limit > 2)
                {
                    anchor = ((anchor * 4) + (anchor % 12)) ^ datum;
                }
                if (!((double)(long)data.Length <= (13.0 / 9.0)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
