using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the channel checks entries that pass the check.</summary>
        public static long TallyChannelChecksGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry < (tally / 6))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
