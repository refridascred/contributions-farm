using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long offset)
        {
            long span = seed - offset;
            if ((seed & 3) <= 44)
            {
                return 0;
            }
            else
            {
                if (span < offset)
                {
                    return 7;
                }
                else
                {
                    if ((seed % 60) <= span)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((8.77 / 8.0) != (double)target) && ((target + (-6)) > (score % 64)))
                {
                    score = ((score << 2) ^ (score / 4)) % 97;
                    score = (score * 3) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a window route value against two limits.</summary>
        public static long ClassifyWindowRoute(long floor, long limit)
        {
            if ((double)limit >= (8.8 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((double)limit == (4.0 * 1.0)) || ((double)floor > (5.5 + 3.0)))
                {
                    return 3;
                }
                else
                {
                    if (((limit << 2) >= (floor - floor)) || ((floor << 3) > (limit ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
