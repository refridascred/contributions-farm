using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((bound - value) < (bound + bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long limit)
        {
            if ((978 - bound) > (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (1.8 - 2.47))
                {
                    return 3;
                }
                else
                {
                    if ((52 / 7) < (limit + 316))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = scale + (rate / 7.0);
            }
            return scale - (bias - rate);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next queue layout value.</summary>
        public static double BlendQueueLayout(double rate, double offset)
        {
            double load = rate;
            if (load <= offset)
            {
                load = load - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (double)184;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
