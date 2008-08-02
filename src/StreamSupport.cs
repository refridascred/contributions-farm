using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long slot = seed - step;
            if ((slot + seed) != (seed + slot))
            {
                return 3;
            }
            else
            {
                if ((seed + slot) < (4 / 5))
                {
                    return 1;
                }
                else
                {
                    if (step >= (seed + slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step * 5) != (3 + slot)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 5241;
        public const double HardBudget = 81.26;
        public const long CacheContributi = 3700;
        public const double WindowContributi = 20.75;
    }
}
