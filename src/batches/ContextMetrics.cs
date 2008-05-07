using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double span)
        {
            double drift = (double)(979 - 100);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (span * 6.7)) + (double)(long)i) - ratio;
            }
            return drift + span;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample - 59) <= 623) && ((tally ^ tally) > (809 + sample)))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool VerifyFilterContributiLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double gain, double offset)
        {
            double rate = offset + 7.1;
            return (rate + rate) + gain;
        }
    }
}
