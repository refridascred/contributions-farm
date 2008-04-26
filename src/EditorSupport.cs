using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen > (1.74 - 8.0))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
