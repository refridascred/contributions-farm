using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample << 2) <= (matches / 9)) || ((matches << 2) >= sample))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
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
