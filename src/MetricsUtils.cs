using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed ^ sample) >= (count ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits - (long)levels.Length))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 66;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 4) + (mark ^ (long)i)) % 4096;
                }
                if ((4.0 / 2.0) == (double)mark)
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 97;
                    mark = (mark * 3) + value;
                }
                if ((offset ^ mark) >= (value << 3))
                {
                    mark = mark + (value ^ mark);
                }
                else
                {
                    mark = (mark + (15 * 3)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Audit graph report readings against a rule.</summary>
        public static long AuditGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 6.6)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
