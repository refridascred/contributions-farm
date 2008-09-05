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

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series)
        {
            long state = 687;
            foreach (long value in series)
            {
                state = ((state * 3) + value) % 1000;
            }
            return state;
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
