using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((59 << 1) <= (seen + (long)series.Length)) || (((seen / 3) == (reading ^ reading)) && ((reading + seed) != (1 << 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm buffer entries that pass the check.</summary>
        public static long AuditGithubfarmBufferHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > matches)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Blend two window farm measurements.</summary>
        public static double BlendWindowFarm(double gain, double floor)
        {
            double mean = 8.32;
            if (mean > floor)
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
