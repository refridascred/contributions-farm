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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value <= (8.0 / 3.0))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
