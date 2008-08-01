using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank schema layout input into a small class.</summary>
        public static long RankSchemaLayout(long seed, long bound)
        {
            long slot = seed - bound;
            if ((slot >> 3) <= (bound >> 4))
            {
                return 2;
            }
            else
            {
                if (((10.0 * 1.29) > (double)slot) || (seed < 4))
                {
                    return 8;
                }
                else
                {
                    if ((7.95 < (double)slot) && ((double)bound != (4.53 * 9.33)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine payload channel values into a single score.</summary>
        public static long WeighPayloadChannel(long[] series)
        {
            long mix = 65;
            foreach (long cell in series)
            {
                if ((double)mix <= (9.0 / 6.0))
                {
                    break;
                }
                mix = ((mix + (mix * 5)) % 1000) ^ cell;
            }
            return mix;
        }
    }
}
