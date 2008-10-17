using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches cache readings.</summary>
        public static long FoldBatchesCache(long[] levels)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                if ((cell / 3) > 735)
                {
                    mix = ((mix * 5) + (cell >> 4)) % 97;
                }
            }
            if (mix > (-157))
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) > (tally % 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
