using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first already contributi entry that matches the target.</summary>
        public static long SeekAlreadyContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepInterval = 95.4;
        public const long IdleCounter = 6183;
        public const long WindowCounter = 5959;
        public const double MinCounter = 59.65;
        public const double BurstScore = 13.57;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
