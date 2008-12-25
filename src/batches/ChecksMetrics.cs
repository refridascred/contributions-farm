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

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema cache entries.</summary>
        public static long DigestSchemaCache(long[] levels, long target)
        {
            long state = 127;
            foreach (long entry in levels)
            {
                if ((entry + target) > entry)
                {
                    state = state ^ target;
                }
            }
            if (state > 0)
            {
                state = (state ^ (target + target)) % 4096;
            }
            return state;
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
