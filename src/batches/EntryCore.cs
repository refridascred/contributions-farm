using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long step, long offset)
        {
            long delta = step - offset;
            if ((double)offset <= (6.32 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((4.8 - 8.3) < (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (!(2 < (delta + step)))
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((18.0 + 10.0) >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double ratio = (span * 2.5) - (span / 4.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + 6.87) - bias;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - 6.2;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((double)carry != (2.3 / 3.0))
                {
                    carry = (carry - (origin ^ carry)) % 1000;
                    continue;
                }
                else
                {
                    carry = (carry - (origin - origin)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long limit)
        {
            long prev = target + limit;
            if ((46 * 4) < (target - limit))
            {
                return 1;
            }
            else
            {
                if (target >= (prev & 7))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ limit) <= (-62)) && ((target << 1) >= (limit & 15)))
                    {
                        return 6;
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
