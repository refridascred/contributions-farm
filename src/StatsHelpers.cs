using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel metric samples.</summary>
        public static long TotalChannelMetric(long[] readings, long offset)
        {
            long acc = 847;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ (acc - offset)) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long bound2)
        {
            if ((bound2 * 5) != (bound >> 1))
            {
                return 2;
            }
            else
            {
                if (!((19.0 * 1.9) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((223 - bound2) > bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound2 << 3) <= (bound + bound2)) && ((5 - bound2) <= (bound2 & 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((offset + tally) > tally)
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if (!((double)step == (double)seed2))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (5.0 * 4.81))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.7 - 13.0) >= (double)seed2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
