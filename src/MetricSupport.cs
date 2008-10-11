using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((5.35 * 0.62) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((10.0 * 11.0) > (double)target) || ((target ^ step) <= 34))
                {
                    return 5;
                }
                else
                {
                    if ((step % 97) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) < (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
