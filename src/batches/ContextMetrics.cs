using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long mix = 560;
            foreach (long cell in series)
            {
                if ((mix + mix) > 8)
                {
                    mix = (mix - (mix * 4)) ^ cell;
                }
            }
            if (mix > 317)
            {
                mix = (mix * 2) + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Find the first queue support entry that matches the target.</summary>
        public static long LocateQueueSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long target)
        {
            long bound = floor ^ target;
            if ((target * 4) < (bound + 73))
            {
                return 4;
            }
            else
            {
                if (((3.82 + 4.0) <= (double)floor) && ((7.0 - 2.04) > (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (4.8 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ target) < (target * 5))
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

        /// <summary>Derive the next layout support value from a seed.</summary>
        public static long StepLayoutSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 3) ^ floor;
                mix = mix ^ (mix - floor);
                if ((mix ^ mix) < mix)
                {
                    mix = (mix ^ mix) % 65521;
                    mix = ((mix * 2) + (floor + 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
