using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry checks value against two limits.</summary>
        public static long RankEntryChecks(long seed, long target)
        {
            if ((target > (seed ^ seed)) && ((target >> 3) < 377))
            {
                return 0;
            }
            else
            {
                if (!((target + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed != (3.8 + 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 94.53;
        public const long LimitLevel = 3281;
        public const string MinScore = "standard-1";
        public const long IdlePayload = 3162;
        public const long MinPayload = 5903;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((step * 4) < (step & 15))
            {
                return 1;
            }
            else
            {
                if (((6.0 + 5.9) < (double)step) || ((double)step2 != (3.5 * 1.7)))
                {
                    return 8;
                }
                else
                {
                    if ((step % 64) >= (step2 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step <= (double)step2) || ((2.66 + 0.73) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session schema value from a seed.</summary>
        public static long RollSessionSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > (seed - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
