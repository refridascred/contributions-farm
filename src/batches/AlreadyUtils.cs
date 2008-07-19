using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 15.0)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long mark = 832;
            foreach (long value in samples)
            {
                mark = (((mark << 2) ^ (value >> 1)) % 1000) - step;
            }
            return mark % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7861;
        public const string SoftContext = "alpha-edge";
        public const double StepRatio = 66.55;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            long diff = offset - limit;
            if ((5.85 * 2.0) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((diff + 70) > (offset * 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
