using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                double load = (double)seed * 4.72;
                if (!(total <= (seed + seed)))
                {
                    total = (total << 2) ^ (seed / 5);
                }
                if (((long)i < seed) && ((load + load) <= load))
                {
                    load = load - load;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
