using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long target)
        {
            long offset = seed - target;
            if ((target & 31) >= seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (6.68 - 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (13.0 + 9.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + 9.0) + (double)(long)i) - span;
            }
            return mean + 2.0;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if (entry <= (anchor << 3))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }
    }
}
