using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFactor = 12.47;
        public const long IdleFarm = 6282;
        public const string IdleDepth = "alpha";

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double span)
        {
            double drift = scale;
            if (drift >= (4.1 + scale))
            {
                drift = (drift - scale) - span;
            }
            else
            {
                drift = drift - 11.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (2.27 + scale)) + (double)(long)i;
            }
            return drift - (double)31;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 8851;
        public const long WindowBatches = 2134;
        public const long DefaultDepth = 94;
        public const double StepInterval = 40.13;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((4 % 7) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
