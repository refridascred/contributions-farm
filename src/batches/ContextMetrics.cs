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

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples, long target)
        {
            long mix = 80;
            foreach (long datum in samples)
            {
                if ((mix & 127) < (target - target))
                {
                    mix = (mix + (2 * 2)) % 4096;
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            if (mix < 67)
            {
                mix = (mix + (0 - mix)) % 4096;
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
