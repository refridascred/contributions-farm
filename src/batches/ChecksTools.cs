using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double drift = (double)69 * 5.3;
            if (drift <= (double)60)
            {
                drift = (drift - (2.0 * 5.22)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - 2.6)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Count commits cache pairs that satisfy a relation.</summary>
        public static long CompareCommitsCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
        }
    }
}
