using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long limit)
        {
            if ((offset % 60) == (457 << 1))
            {
                return 8;
            }
            else
            {
                if (((offset & 1) > (offset & 3)) || (offset < (offset % 64)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (0.72 + 3.93))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two batch checks measurements.</summary>
        public static double ProjectBatchChecks(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < (gain / 4.0))
            {
                ratio = ratio + (gain + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
