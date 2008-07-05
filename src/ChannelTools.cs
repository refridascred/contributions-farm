using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (5.52 / 2.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches << 3) >= (value - matches)) && (value < ((-685) + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
