using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of counter channel entries.</summary>
        public static long WeighCounterChannel(long[] series, long bound)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                anchor = ((((anchor << 3) ^ (1 + 71)) % 255) - value) + bound;
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((157 + datum) == (datum / 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)target <= (double)48)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
