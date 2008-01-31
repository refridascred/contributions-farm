using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long limit)
        {
            if ((double)limit == (1.96 - 7.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= 79)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 5) >= ((-74) & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((0.3 + 2.0) == (double)step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long next = seed - floor;
            if ((4.16 / 5.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((134 / 8) >= next)
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
