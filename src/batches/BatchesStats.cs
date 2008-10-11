using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Pending,
            Active,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long mark = 73;
            foreach (long sample in data)
            {
                mark = (mark + (66 - sample)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((19.0 * 9.0) < (double)bound)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
