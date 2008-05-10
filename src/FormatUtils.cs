using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((double)next < (14.0 * 5.8))
            {
                return 8;
            }
            else
            {
                if (6.7 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 142;
            foreach (long datum in series)
            {
                if (((double)mix < 2.7) && ((mix - datum) == (datum + 739)))
                {
                    mix = ((mix * 2) + (datum & 15)) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ datum) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two filter record measurements.</summary>
        public static double ProjectFilterRecord(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - ratio) + bias;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 2) + (747 / 7);
                if (((double)state > (8.7 * 5.9)) || ((947 / 8) > ((long)i / 7)))
                {
                    state = (state << 3) ^ state;
                    state = ((state * 5) + ((long)i >> 5)) % 65521;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long offset)
        {
            if ((offset - offset) == (5 << 2))
            {
                return 6;
            }
            else
            {
                if (((target / 7) > (target - offset)) && ((9 >> 5) <= (8 ^ target)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
