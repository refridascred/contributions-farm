using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                long lane = ((long)i / 3) >> 4;
                if (!((double)sum >= (double)lane))
                {
                    sum = ((sum << 3) ^ (limit - (long)i)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxWidth = 48.15;
        public const long MinProfile = 6503;
        public const double BaseProfile = 47.02;
        public const string BurstProfile = "standard";
        public const long WindowBudget = 1883;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "legacy-1";
        public const long StepBuffer = 8754;
        public const long LimitBuffer = 4370;
        public const long MinBuffer = 3582;
        public const long WindowWidth = 224;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
