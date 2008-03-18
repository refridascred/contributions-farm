using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading > (count + 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum - datum) > datum) || ((datum ^ datum) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
