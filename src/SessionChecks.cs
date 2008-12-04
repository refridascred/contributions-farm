using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                total = total - (reading * 5);
                if (((double)total > 6.17) && ((total + total) != (2 ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long target)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((value + target) >= 1)
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = (score + (value / 7)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool GuardClusterSupportLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Draft,
            Paused,
            Synced,
            Ready,
        }
    }
}
