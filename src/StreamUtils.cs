using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2009;
        public const string IdleDepth = "open";
        public const string DefaultSession = "primary-1";
        public const double LimitLevel = 36.06;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long sum = 469;
            foreach (long datum in levels)
            {
                if ((double)sum <= (7.0 - 0.62))
                {
                    sum = ((sum * 3) + sum) % 101;
                    sum = ((sum * 3) + (9 + sum)) % 4096;
                }
                if (((datum >> 5) > (55 >> 3)) || ((88 - sum) <= sum))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                    sum = (sum - (sum ^ 905)) % 65521;
                    break;
                }
                if ((datum - sum) == (sum - datum))
                {
                    sum = sum - (datum ^ 904);
                }
            }
            if (sum < 934)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Stale,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Blend two channel stream measurements.</summary>
        public static double AdjustChannelStream(double scale, double bias)
        {
            double mean = scale;
            if (mean > mean)
            {
                mean = mean + (mean + scale);
            }
            return mean + bias;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((4.3 / 7.0) != (double)step)
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
