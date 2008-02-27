using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate payload already readings against a bound.</summary>
        public static bool GuardPayloadAlreadyLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long ClassifyWindowCounter(long origin, long limit)
        {
            if (limit >= (origin << 3))
            {
                return 6;
            }
            else
            {
                if ((origin - limit) >= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry / 7) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter batches reading.</summary>
        public static double AdjustFilterBatches(double bias, double floor)
        {
            double drift = 3.59;
            if (drift < (double)643)
            {
                drift = drift - (bias + bias);
            }
            else
            {
                drift = drift + 3.51;
            }
            return drift - floor;
        }
    }
}
