using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((7.0 + 3.3) < (double)hits)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(884 & 63);
            if (ratio > (double)5)
            {
                ratio = ratio - (bias * 9.0);
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) <= (922 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
