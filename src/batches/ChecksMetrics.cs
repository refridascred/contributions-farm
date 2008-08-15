using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 5389;
        public const string SoftScore = "primary";
        public const long WindowChannel = 3220;
        public const long BaseChannel = 8976;

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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8341;
        public const long BaseSpan = 9560;
        public const double MinInterval = 43.17;
        public const long LimitWidth = 8707;
        public const long BurstScore = 3927;

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
