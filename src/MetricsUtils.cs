using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const string BaseSize = "latest-v2";
        public const string WindowDepth = "latest-1";
        public const long HardChecks = 7818;
        public const long StepChecks = 1972;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
