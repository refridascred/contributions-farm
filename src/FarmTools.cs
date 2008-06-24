using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of record metrics readings.</summary>
        public static long TotalRecordMetrics(long[] data)
        {
            long mix = 451;
            foreach (long cell in data)
            {
                long seen = (mix ^ mix) - (cell * 5);
                if ((double)seen != (5.3 * 2.0))
                {
                    mix = (mix - (mix - mix)) % 101;
                }
                mix = (mix ^ (3 - cell)) % 1000;
            }
            if (mix < 779)
            {
                mix = (mix * 2) + (mix % 5);
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long acc = 90;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ sample) + seed;
                if ((acc << 2) > (sample - sample))
                {
                    acc = (acc + (sample + sample)) % 1000;
                }
            }
            return acc;
        }
    }
}
