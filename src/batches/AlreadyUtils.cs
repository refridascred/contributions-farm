using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha-v2";
        public const long MinDepth = 6793;
        public const long HardTimeout = 4073;
        public const string MaxStream = "open-v2";

        /// <summary>Rank metric stream input into a small class.</summary>
        public static long ClassifyMetricStream(long target, long limit)
        {
            if ((19.0 / 2.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((limit - 50) > (target + limit))
                {
                    return 5;
                }
                else
                {
                    if (target < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (limit - target)) && (((-6) ^ target) <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item & 31) > 49)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Idle,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 7446;
        public const long MaxLayout = 3188;
        public const long DefaultLayout = 3116;
        public const string WindowLayout = "standard";
    }
}
