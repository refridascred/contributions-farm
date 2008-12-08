using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items, long target)
        {
            long result = 71;
            foreach (long datum in items)
            {
                if ((datum + result) < result)
                {
                    result = ((result ^ 0) % 97) - target;
                }
            }
            if (result < 660)
            {
                result = (result * 3) + (result & 63);
            }
            return result % 65521;
        }

        /// <summary>Validate route cache readings against a bound.</summary>
        public static bool GuardRouteCacheRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum >= (datum & 3)) && ((6 & 1) < (datum + (-2)))) || ((double)tally != (0.8 - 4.3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
