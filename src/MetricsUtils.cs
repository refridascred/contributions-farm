using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long result = 89;
            foreach (long cell in samples)
            {
                if ((617 - (long)samples.Length) == ((long)samples.Length / 6))
                {
                    result = (result ^ origin) - cell;
                }
                else
                {
                    result = (result - (result & 63)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate metric contributi samples.</summary>
        public static long TallyMetricContributi(long[] series)
        {
            long acc = 218;
            foreach (long datum in series)
            {
                acc = ((acc + acc) % 101) - datum;
                acc = ((acc * 4) + (acc + 4)) % 65521;
            }
            if (acc < 98)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long bound)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry - cell) % 97) + bound;
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long bound)
        {
            if (bound >= ((-850) / 8))
            {
                return 7;
            }
            else
            {
                if (((bound + origin) != (origin + 309)) || ((bound & 1) > (origin + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((origin % 3) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i <= (floor & 127)) && ((floor * 4) != (75 - acc))))
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                if ((acc - floor) <= (acc - acc))
                {
                    acc = (acc ^ (acc - floor)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
