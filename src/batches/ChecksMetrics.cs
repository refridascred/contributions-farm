using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((3.78 - 18.0) != (double)target)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long AuditChannelMetricsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading >> 3) != (reading + count)) || ((reading - count) <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double floor)
        {
            double ratio = floor / 8.0;
            if (ratio <= (scale * 20.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (floor / 6.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
