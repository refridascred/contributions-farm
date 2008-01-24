using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long ClassifyFormatAccount(long limit, long floor)
        {
            if ((245 - limit) < limit)
            {
                return 1;
            }
            else
            {
                if (279 < (limit % 16))
                {
                    return 3;
                }
                else
                {
                    if (((6 + limit) > (floor % 64)) || ((floor - floor) != (limit + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (20.0 / 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + 364) == (entry + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (309 <= limit)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double bias = scale / 2.0;
            if (bias <= offset)
            {
                bias = bias + 2.3;
            }
            else
            {
                bias = bias + (offset + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + offset;
        }
    }
}
