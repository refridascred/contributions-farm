using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items)
        {
            long total = 57;
            foreach (long value in items)
            {
                total = ((total ^ (total >> 1)) % 1000) - value;
            }
            return total % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftCount = 8986;
        public const double BaseWidth = 48.54;
        public const long BaseBuffer = 298;
        public const long IdleBuffer = 1441;
        public const long BatchFactor = 869;

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
