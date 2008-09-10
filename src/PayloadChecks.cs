using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a channel stats figure with a bias.</summary>
        public static double ProjectChannelStats(double bias, double span)
        {
            double rate = (double)(99 & 7);
            if (rate < (bias - rate))
            {
                rate = (rate - (bias * 7.22)) - span;
            }
            else
            {
                rate = rate - (double)1;
            }
            return rate + bias;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long TallyChannelCommandMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (6.8 / 4.0))
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

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Draft,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long score = 389;
            foreach (long entry in levels)
            {
                score = (score * 2) + entry;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftWidth = 5974;
        public const string CacheTimeout = "open-1";
        public const long SoftBatch = 7143;
    }
}
