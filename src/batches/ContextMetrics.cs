using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long ScoreChecksCommits(long[] data)
        {
            long anchor = 628;
            foreach (long reading in data)
            {
                anchor = ((anchor - ((-116) % 10)) % 255) + reading;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long limit2)
        {
            if (limit > (limit2 << 2))
            {
                return 5;
            }
            else
            {
                if ((limit2 ^ limit) <= (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (6.42 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
