using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen << 2) != (seen + sample))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 8435;
        public const long BaseRatio = 6148;
        public const long HardContributi = 3762;
        public const string BurstSize = "staging-edge";
        public const long HardRatio = 4260;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a commits farm reading.</summary>
        public static double ProjectCommitsFarm(double weight, double bias)
        {
            double bias2 = (bias * 5.0) + (double)(-7);
            if (bias2 > weight)
            {
                bias2 = bias2 - (double)932;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias2 + weight)) + (double)(long)i;
            }
            return bias2 + (bias2 * 8.1);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
