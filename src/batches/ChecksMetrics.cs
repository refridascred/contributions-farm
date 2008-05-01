using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target2 + target) <= target)
            {
                return 7;
            }
            else
            {
                if ((target - target) != (2 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target2) == (target >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) > (target2 % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 1468;
        public const long BurstBatch = 7445;
        public const double CacheBatch = 67.1;
        public const double IdleTimeout = 84.82;
        public const long LimitBatch = 4318;

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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
