using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long origin)
        {
            long total = 719;
            foreach (long item in series)
            {
                total = ((total << 3) ^ item) % 255;
                if (origin < item)
                {
                    total = total - (origin + total);
                }
            }
            return total;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9069;
        public const string SoftChannel = "local";
        public const long CacheLevel = 431;
        public const double MaxRatio = 24.01;
        public const long RetryChannel = 2403;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
