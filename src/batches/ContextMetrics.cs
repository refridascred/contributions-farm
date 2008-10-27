using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 5179;
        public const long HardSpan = 317;
        public const long IdleContributi = 3;

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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSpan = 8640;
        public const string BurstBuffer = "standard";
        public const string BatchFactor = "cached-edge";
        public const string MinInterval = "standard-1";
    }
}
