using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long seed, long seed2)
        {
            if ((seed + 6) == (4 + seed2))
            {
                return 2;
            }
            else
            {
                if (((seed & 255) > (6 & 255)) || ((seed2 / 9) < seed2))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 == (5.1 * 20.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed2 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long offset)
        {
            long next = origin ^ offset;
            if ((next & 63) == (origin & 7))
            {
                return 2;
            }
            else
            {
                if (((20.0 - 8.59) > (double)next) || ((double)offset >= (6.9 * 0.4)))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) < (next % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.0 + 4.0) >= (double)next) && (origin < (offset & 127)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
