using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                if ((reading / 3) >= reading)
                {
                    sum = ((sum << 3) ^ (origin << 3)) % 255;
                }
            }
            if (sum < 785)
            {
                sum = (sum << 2) ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
