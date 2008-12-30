using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) < (sample ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
