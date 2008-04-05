using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict";
        public const string StepInterval = "stable";
        public const long DefaultProfile = 3436;
        public const double BatchProfile = 35.66;

        /// <summary>Rank filter queue input into a small class.</summary>
        public static long SortFilterQueue(long target, long seed)
        {
            if (((seed % 2) == (seed + 0)) && ((seed - 537) != (seed - target)))
            {
                return 3;
            }
            else
            {
                if ((899 - 55) > (seed + target))
                {
                    return 6;
                }
                else
                {
                    if (target > (1 + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target * 3) >= seed) && ((30 + target) <= (target << 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)matches == (1.8 / 3.0)) || ((sample * 5) <= (sample / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (((78 - bound) > ((-76) % 3)) && ((step - bound) != (47 << 1)))
            {
                return 5;
            }
            else
            {
                if ((bound - 67) > (step / 9))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Failed,
            Paused,
            Done,
        }
    }
}
