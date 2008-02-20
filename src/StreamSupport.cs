using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long limit)
        {
            long slot = bound - limit;
            if ((limit / 9) <= slot)
            {
                return 0;
            }
            else
            {
                if (slot >= (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound * 2) >= 2) || ((slot % 60) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - limit) > (slot % 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8208;
        public const long BurstInterval = 5227;
        public const long StepSchema = 1534;
        public const string HardFactor = "cached-edge";

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
