using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long step)
        {
            long span = limit ^ step;
            if (((11.0 / 7.0) <= (double)limit) && ((span / 3) == (25 & 1)))
            {
                return 8;
            }
            else
            {
                if (span > (step ^ span))
                {
                    return 3;
                }
                else
                {
                    if ((279 - span) < 2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit << 2) <= (4 % 64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i >> 2) <= origin)
                {
                    continue;
                }
                mark = mark - mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally ^ (long)samples.Length))
                {
                    tally = ((tally + 1) + cell) - offset;
                }
            }
            return tally;
        }
    }
}
