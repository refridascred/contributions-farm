using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 7296;
        public const long DefaultCommand = 4761;
        public const long HardCommand = 5820;
        public const long IdleLevel = 5337;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 695;
            foreach (long reading in data)
            {
                if ((double)reading < 5.78)
                {
                    result = result ^ (reading % 10);
                }
                result = ((result * 4) + reading) % 97;
            }
            return result;
        }

        /// <summary>Rank filter report input into a small class.</summary>
        public static long RankFilterReport(long origin, long floor)
        {
            long diff = origin - floor;
            if (floor > (177 >> 3))
            {
                return 4;
            }
            else
            {
                if (((origin & 127) >= origin) || (diff > (origin >> 4)))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 + 0.2) <= (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((731 + origin) == (origin >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 7912;
        public const string BurstLevel = "staging-1";
        public const long StepLevel = 5020;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (1.14 + 6.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
