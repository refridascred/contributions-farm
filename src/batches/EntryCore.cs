using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5481;
        public const long CacheEntry = 6614;
        public const long LimitSize = 6489;
        public const double SoftEntry = 79.53;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double drift = (double)(64 - 107);
            if (drift < (bias / 2.0))
            {
                drift = (drift + drift) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
