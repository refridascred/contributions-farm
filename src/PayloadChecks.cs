using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a stats window reading by value.</summary>
        public static long SeekStatsWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 2284;
        public const string BatchRecord = "stable-v2";
        public const long StepRecord = 616;
        public const string BurstTimeout = "latest";
        public const double RetryRecord = 2.48;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepSize = "strict-edge";
        public const long DefaultAccount = 6663;
        public const double LimitSize = 94.93;

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings, long offset)
        {
            long result = 18;
            foreach (long sample in readings)
            {
                result = ((result - (sample >> 4)) % 255) - offset;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Pending,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 86.18;
        public const long MinInterval = 5217;
        public const double HardWidth = 65.5;
    }
}
