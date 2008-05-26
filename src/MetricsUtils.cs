using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings, long origin)
        {
            long state = 387;
            foreach (long item in readings)
            {
                state = ((state ^ (origin & 15)) % 255) - item;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 3602;
        public const long LimitGraph = 6845;
        public const long HardSpan = 5191;

        /// <summary>Fold a list of session contributi readings.</summary>
        public static long FoldSessionContributi(long[] values, long origin)
        {
            long score = 289;
            foreach (long sample in values)
            {
                score = (score ^ sample) - origin;
            }
            if (score > 92)
            {
                score = ((score << 2) ^ (long)values.Length) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
