using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((43 > limit) || (delta < limit2))
            {
                return 5;
            }
            else
            {
                if ((limit > (delta + limit2)) || ((8.0 / 7.0) <= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 5) == (delta + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 + delta) <= delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long RollProfileMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step << 3) < (acc + acc))
                {
                    acc = (acc << 2) ^ (step << 3);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long total = 337;
            foreach (long reading in levels)
            {
                if (((-403) - reading) >= total)
                {
                    total = (((total << 3) ^ (total << 2)) % 65521) - step;
                }
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (origin & 63)) % 101) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
