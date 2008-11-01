using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long floor, long seed)
        {
            long prev = floor + seed;
            if (!(((-13) + seed) >= (prev & 15)))
            {
                return 5;
            }
            else
            {
                if (!(seed <= (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i == (offset / 8)))
                {
                    mix = (mix ^ mix) % 97;
                }
                mix = ((mix * 5) + ((long)i & 7)) % 255;
                mix = mix + (2 - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
