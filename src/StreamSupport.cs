using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (double)item)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long limit)
        {
            long sum = -72;
            foreach (long sample in data)
            {
                if ((sum << 1) >= (sum + limit))
                {
                    sum = (((sum * 3) + (sum << 1)) % 101) ^ sample;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if (((long)data.Length / 5) != (sum >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 1) >= (hits - bound))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
