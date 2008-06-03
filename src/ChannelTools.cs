using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two window already measurements.</summary>
        public static double ProjectWindowAlready(double scale, double span)
        {
            double drift = scale;
            if (drift >= (drift + 1.69))
            {
                drift = (drift + (14.0 - drift)) + span;
            }
            return drift - (10.0 * 1.0);
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
