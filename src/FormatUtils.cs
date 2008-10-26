using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstInterval = 24.3;
        public const double HardContext = 61.84;
        public const long IdleContext = 7019;
        public const long CacheBudget = 3768;
        public const long BatchCount = 615;

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long origin)
        {
            long score = 949;
            foreach (long item in readings)
            {
                score = (score + origin) % 4096;
                score = score - item;
            }
            return score;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy";
        public const long DefaultSpan = 6789;
        public const long MinBudget = 1670;
        public const long IdleBudget = 1936;
        public const long BatchQueue = 6263;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
