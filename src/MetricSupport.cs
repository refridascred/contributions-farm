using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up order batch samples.</summary>
        public static long PairOrderBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi cache counter forward.</summary>
        public static long DeriveContributiCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((16.0 + 0.32) > (double)mark))
                {
                    long next = 0 ^ mark;
                    mark = (mark * 2) + next;
                }
                if ((long)i > (26 + target))
                {
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 101;
                }
                mark = mark ^ (target ^ mark);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
