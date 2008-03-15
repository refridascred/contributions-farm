using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "stable-1";
        public const long MinReport = 9447;
        public const long DefaultSize = 3591;
        public const long HardReport = 7823;
        public const long CacheLevel = 4935;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long bound)
        {
            long next = target ^ bound;
            if (next <= (next * 5))
            {
                return 8;
            }
            else
            {
                if (((double)target >= (10.0 * 1.48)) || ((next << 2) > (74 - next)))
                {
                    return 0;
                }
                else
                {
                    if (((target / 8) != (bound ^ target)) && ((double)target > (5.0 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
