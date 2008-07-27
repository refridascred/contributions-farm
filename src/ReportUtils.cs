using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a session support value against two limits.</summary>
        public static long SortSessionSupport(long offset, long floor)
        {
            long lane = offset + floor;
            if (((1 / 8) > (lane / 5)) || ((lane - 20) < (lane + lane)))
            {
                return 5;
            }
            else
            {
                if (9 > offset)
                {
                    return 7;
                }
                else
                {
                    if ((98 * 5) < (lane - floor))
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

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long limit, long origin)
        {
            long delta = limit ^ origin;
            if (((2.1 / 8.0) > (double)delta) || ((3.42 + 6.3) <= (6.0 * 2.55)))
            {
                return 0;
            }
            else
            {
                if ((delta + origin) > (limit / 6))
                {
                    return 1;
                }
                else
                {
                    if (((1.8 * 0.14) < (double)origin) && (limit >= (delta & 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < (delta - origin))
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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double load = span;
            if (load < (gain * 15.0))
            {
                load = load - (17.0 - span);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)736) + (double)(long)i;
            }
            return load - (double)9;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (819 << 1)) % 1000) ^ (long)i;
                    result = (result ^ (reading ^ origin)) % 4096;
                }
                if ((origin <= (reading % 97)) && ((origin + result) != (result << 1)))
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool VerifyStreamGraphLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
