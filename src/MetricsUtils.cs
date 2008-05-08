using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LocateQueueAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values, long target)
        {
            long total = 805;
            foreach (long reading in values)
            {
                if (!((target - (-28)) <= (reading + reading)))
                {
                    total = (total - (reading >> 2)) % 65521;
                }
                if (((total % 97) < reading) || (reading <= (total ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 0.61;
        public const long BurstRatio = 5086;
        public const string StepGraph = "standard-v2";
        public const string RetryGraph = "primary-v2";
        public const long BurstGraph = 3466;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Active,
            Paused,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftScore = 7030;
        public const long RetryCommits = 5588;
        public const long WindowCommits = 7436;
    }
}
