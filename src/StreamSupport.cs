using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double ratio = gain;
            return ratio + (floor - 0.12);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long limit)
        {
            long offset = seed - limit;
            if (((offset - offset) < (offset << 3)) && (seed > (205 + 1)))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= 10.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit already channel readings against a rule.</summary>
        public static long MeasureAlreadyChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((reading / 2) > (reading * 4)) && (hits >= (reading + reading))) || (((reading + hits) > (hits - hits)) && ((reading + reading) < (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
