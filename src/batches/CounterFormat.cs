using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank token report input into a small class.</summary>
        public static long BucketTokenReport(long limit, long limit2)
        {
            long bound = limit - limit2;
            if (237 <= (bound ^ 94))
            {
                return 4;
            }
            else
            {
                if (limit <= (bound >> 1))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (271 < (limit / 7))
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 3) < 61)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Validate stats farm readings against a bound.</summary>
        public static bool ValidateStatsFarmBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
