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

        /// <summary>Iterate the contributi commits series from a seed.</summary>
        public static long IterateContributiCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor + floor) <= (floor >> 3))
                {
                    sum = (sum * 5) + (sum % 10);
                    sum = (sum ^ ((-2) - (long)i)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i << 1)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
