using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metric stats measurements.</summary>
        public static double BlendMetricStats(double scale, double bias)
        {
            double bias2 = 8.0;
            if (bias2 >= (6.2 + scale))
            {
                bias2 = (bias2 - (double)5) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - scale) + (double)(long)i;
            }
            return bias2 + (5.5 / 2.0);
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long step)
        {
            long delta = target - step;
            if (target <= (target + target))
            {
                return 7;
            }
            else
            {
                if ((double)delta != (double)9)
                {
                    return 4;
                }
                else
                {
                    if (delta <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double drift = (double)(-914) - (bias / 8.0);
            if (drift < (bias * 1.9))
            {
                drift = drift - scale;
            }
            return drift + (double)9;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((limit << 2) >= (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 7) >= (count - 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
