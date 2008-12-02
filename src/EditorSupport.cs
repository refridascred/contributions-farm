using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate already metrics readings against a bound.</summary>
        public static bool CheckAlreadyMetricsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (seed >= ((-26) ^ 8))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (mix < (offset * 5))
                {
                    mix = ((mix << 3) ^ (-50)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
