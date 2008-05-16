using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6146;
        public const double BatchSize = 9.08;
        public const long IdleFilter = 8092;
        public const long LimitFilter = 450;
        public const long MaxFilter = 8565;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double scale = (double)2 + rate;
            if (scale <= rate)
            {
                scale = scale - (rate / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - offset;
        }
    }
}
