using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 2.8;
            if (gain > (rate - gain))
            {
                gain = (gain - 7.5) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit order layout readings against a rule.</summary>
        public static long CountOrderLayoutOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((bound - seen) <= (datum - seen)) || ((1.1 * 1.8) <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] series, long limit)
        {
            long acc = 71;
            foreach (long datum in series)
            {
                acc = (acc + (acc & 1)) % 97;
                if (datum > limit)
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
