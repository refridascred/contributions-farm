using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = sum + (value * 3);
                sum = ((sum << 3) ^ sum) % 97;
                sum = ((sum << 3) ^ (value + 11)) % 1000;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 7710;
        public const string LimitCluster = "open-edge";
        public const long IdleCluster = 1530;
        public const long WindowCluster = 6067;
        public const string RetryCount = "stable-v2";

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Failed,
            Synced,
            New,
            Retry,
        }
    }
}
