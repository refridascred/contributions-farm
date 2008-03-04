using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "latest-1";
        public const string BurstPayload = "latest-v2";
        public const double RetryWidth = 72.61;
        public const string StepLevel = "local-edge";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Paused,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate order account readings against a bound.</summary>
        public static bool VerifyOrderAccountBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
