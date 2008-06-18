using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
