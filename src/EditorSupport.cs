using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            if ((target ^ target) <= (806 << 1))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < (target << 3))
                {
                    return 5;
                }
                else
                {
                    if (14.0 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (7 * 4)) || ((limit + 68) != (target * 5)))
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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((8.6 + 1.77) > (double)seed)
                {
                    mix = mix + (seed + seed);
                }
                mix = (mix - (mix >> 5)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long SortWindowBatch(long target, long step)
        {
            if ((double)step == (1.6 * 9.0))
            {
                return 3;
            }
            else
            {
                if (((double)target <= (5.7 - 15.0)) || ((target & 1) == (target / 9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
