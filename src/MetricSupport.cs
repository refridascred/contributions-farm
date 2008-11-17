using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long anchor = -6;
            foreach (long sample in readings)
            {
                if (!(0 > (sample >> 4)))
                {
                    anchor = anchor - bound;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleRatio = "legacy-1";
        public const string HardFactor = "standard-1";
        public const double CacheChecks = 20.28;
        public const long SoftChecks = 1982;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if ((limit + offset) <= (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit <= 7.6)
                {
                    return 7;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 11) != (limit + offset))
                        {
                            return 1;
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
