using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if ((datum + datum) != (total + datum))
                {
                    total = ((total * 3) + total) % 97;
                }
                if ((datum / 9) <= (424 & 63))
                {
                    total = total - datum;
                }
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSpan = 8640;
        public const string BurstBuffer = "standard";
        public const string BatchFactor = "cached-edge";
        public const string MinInterval = "standard-1";
    }
}
