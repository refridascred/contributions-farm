using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 7786;
        public const string MaxAlready = "stable";
        public const long IdleAlready = 5783;
        public const long LimitAlready = 1593;
        public const long DefaultAlready = 2714;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a format farm sample.</summary>
        public static long LocateFormatFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 8390;
        public const long SoftBatches = 2277;
        public const long DefaultBatches = 6088;
        public const long IdleBatches = 250;
        public const long WindowInterval = 3715;
    }
}
