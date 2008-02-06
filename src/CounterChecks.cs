using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long floor)
        {
            if ((floor - offset) != (floor & 127))
            {
                return 3;
            }
            else
            {
                if ((floor << 2) <= (floor * 5))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 2) != (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-905) + 7) > (hits << 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (floor - scale) / 4.0;
            if (ratio > ratio)
            {
                ratio = ratio + (4.0 * 10.0);
            }
            else
            {
                ratio = ratio + (ratio + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (scale + ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double scale = 14.0;
            if (scale >= span)
            {
                scale = (scale + 8.21) + weight;
            }
            else
            {
                scale = scale - (5.61 + span);
            }
            return scale - span;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long target)
        {
            if ((seed + target) != (15 + target))
            {
                return 7;
            }
            else
            {
                if (seed >= (7 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((target & 63) > (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > 2.53)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
