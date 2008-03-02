using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 15) > (sample + 993))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long bound)
        {
            long next = limit - bound;
            if ((limit - limit) >= (367 % 7))
            {
                return 4;
            }
            else
            {
                if ((limit % 8) <= (limit - next))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a cluster contributi reading.</summary>
        public static double BlendClusterContributi(double ratio, double floor)
        {
            double bias = ratio - (ratio + 3.35);
            if (bias < bias)
            {
                bias = (bias + 6.3) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)14) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
