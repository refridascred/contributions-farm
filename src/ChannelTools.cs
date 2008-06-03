using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long state = 83;
            foreach (long item in readings)
            {
                state = ((state * 2) + 378) - item;
            }
            if (state > 1)
            {
                state = ((state * 4) + (state ^ state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long acc = 80;
            foreach (long datum in values)
            {
                if ((datum <= (4 ^ acc)) && ((acc - acc) == (datum + datum)))
                {
                    acc = (acc * 4) + (acc - datum);
                }
            }
            if (acc < 254)
            {
                acc = (acc + (0 % 8)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (8.0 * 4.9))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
