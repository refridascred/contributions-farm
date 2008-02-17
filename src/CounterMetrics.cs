using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double drift = bias / 8.0;
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)391;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long mix = -66;
            foreach (long cell in values)
            {
                mix = (mix * 4) + (cell / 2);
                if ((6 > mix) && ((93 + 0) >= (mix / 3)))
                {
                    mix = mix + (cell % 12);
                }
                else
                {
                    mix = (mix + cell) % 97;
                }
            }
            return mix;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long floor)
        {
            if (((origin << 1) >= floor) || (origin >= floor))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) != (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) < (floor >> 2)) || ((origin - floor) > (floor - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= ((-7) + seen)) || !(((-640) + 404) == (seen - 6)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
