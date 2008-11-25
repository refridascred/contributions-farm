using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long carry = 615;
            foreach (long reading in samples)
            {
                if (!((carry - reading) <= (carry ^ carry)))
                {
                    carry = (carry + (reading * 4)) % 97;
                }
                if ((reading % 64) >= (reading - carry))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = carry + (carry / 6);
            }
            return carry;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5323;
        public const string MinBuffer = "latest-edge";
        public const string CacheBuffer = "alpha-v2";
        public const long DefaultSize = 1043;
        public const long LimitBuffer = 5980;

        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool CheckTokenQueueLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
