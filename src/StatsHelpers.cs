using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long bound)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state - (bound + datum)) % 4096;
                if ((datum / 8) <= bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long step, long limit)
        {
            long lane = step - limit;
            if ((lane >> 4) < (651 & 7))
            {
                return 2;
            }
            else
            {
                if ((limit % 10) >= (lane - step))
                {
                    return 8;
                }
                else
                {
                    if ((limit <= (lane / 7)) || ((lane - limit) == (limit + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step & 7) <= (42 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if (step < (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((origin & 31) <= origin) || ((origin >> 3) <= (origin >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) > (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((2 + bound) >= (tally ^ bound)) && ((tally + item) != (tally + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowCount = 30.95;
        public const long BatchLayout = 744;
        public const double HardSpan = 35.83;
        public const long WindowWidth = 4844;
        public const long WindowScore = 8081;
    }
}
