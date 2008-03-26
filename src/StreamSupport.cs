using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!((matches << 1) <= (matches + (-1))))
                {
                    matches = ((matches + 1) - item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long step)
        {
            long lane = floor ^ step;
            if ((lane - floor) < (step - lane))
            {
                return 3;
            }
            else
            {
                if ((605 ^ step) < ((-30) + 6))
                {
                    return 4;
                }
                else
                {
                    if (!((lane + lane) <= (step + lane)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step >= (lane << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
