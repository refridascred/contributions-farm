using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (980 < (matches - seed))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double scale = (span + ratio) * 9.0;
            if (scale > (double)(-95))
            {
                scale = scale + span;
            }
            return scale + ratio;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double drift = (span / 9.0) * 6.35;
            if (drift < span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + (drift / 2.0);
        }
    }
}
