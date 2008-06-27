using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mark = 82;
            foreach (long datum in levels)
            {
                mark = (((mark << 3) ^ mark) % 97) ^ datum;
            }
            return mark % 4096;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value & 31) != (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = (score ^ (entry << 1)) % 97;
            }
            if (score > (-40))
            {
                score = (score - (446 >> 3)) % 65521;
            }
            return score;
        }
    }
}
