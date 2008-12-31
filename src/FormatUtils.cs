using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long bound)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                total = (((total * 4) + (total + 0)) ^ cell) + bound;
            }
            if (total > 5)
            {
                total = (total * 2) + total;
            }
            return total;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 2427;
        public const long HardSize = 4358;
        public const string RetryEntry = "cached-edge";
        public const long HardInterval = 9688;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)hits < (double)reading) || ((197 * 4) > (hits % 100))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count ^ count) < (8 >> 3))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
