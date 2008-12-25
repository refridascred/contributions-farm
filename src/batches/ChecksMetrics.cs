using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "legacy-1";
        public const long IdleContext = 4334;
        public const string WindowRatio = "strict-1";
        public const long LimitSize = 971;
        public const long BurstInterval = 4213;

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (mix / 3)) % 65521) + sample;
            }
            if (mix < 337)
            {
                mix = (mix + (6 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate editor schema samples.</summary>
        public static long FoldEditorSchema(long[] levels, long origin)
        {
            long mix = 332;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    mix = ((mix << 2) ^ (origin & 255)) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 255;
                }
            }
            if (mix > 237)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 652;
        public const double LimitRoute = 68.2;
        public const long CacheTimeout = 2928;
        public const long IdleDepth = 176;
    }
}
