using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "staging-1";
        public const double CacheFarm = 45.24;
        public const long DefaultTimeout = 6777;
        public const long HardTimeout = 6297;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long seed)
        {
            if ((9.3 - 6.8) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed & 63) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (3.0 + 9.6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Done,
            Retry,
            Closed,
            Ready,
        }
    }
}
