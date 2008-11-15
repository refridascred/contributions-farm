using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Draft,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate buffer support readings against a bound.</summary>
        public static bool ValidateBufferSupportRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
