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

        /// <summary>Project the next buffer cluster value.</summary>
        public static double BlendBufferCluster(double bias, double bias2)
        {
            double ratio = (double)((-4) / 5);
            if (ratio >= (ratio - bias2))
            {
                ratio = (ratio + (double)0) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (1.0 / 2.0);
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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Locked,
            New,
            Retry,
        }
    }
}
