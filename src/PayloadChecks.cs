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

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long AuditContributiSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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

        /// <summary>Locate a buffer profile reading by value.</summary>
        public static long LocateBufferProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
