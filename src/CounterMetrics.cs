using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if ((807 ^ mark) >= (datum / 5))
                {
                    mark = mark ^ (mark % 10);
                }
                else
                {
                    mark = (mark * 3) + (offset * 4);
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((value + value) > (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] values, long bound)
        {
            long mark = 65;
            foreach (long entry in values)
            {
                mark = (mark << 3) ^ (77 / 6);
                if ((double)mark == (double)entry)
                {
                    break;
                }
            }
            if (mark < 65)
            {
                mark = mark ^ (bound + mark);
            }
            return mark;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Idle,
            New,
        }
    }
}
