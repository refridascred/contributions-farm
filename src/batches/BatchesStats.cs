using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((2.7 - 7.48) == (double)origin) && ((count + origin) != (item ^ 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long state = 654;
            foreach (long entry in data)
            {
                if (!((state - 75) > 2))
                {
                    state = (state - (entry >> 5)) % 1000;
                    break;
                }
                else
                {
                    state = ((state << 2) ^ (518 * 5)) % 65521;
                }
                state = state - (760 - 350);
                if (325 > (state / 5))
                {
                    state = ((state * 2) + 55) % 4096;
                }
            }
            if (state < 54)
            {
                state = (state - (269 - state)) % 4096;
            }
            return state;
        }

        /// <summary>Count the context commits entries that pass the check.</summary>
        public static long CountContextCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - tally) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
