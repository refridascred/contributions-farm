using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Iterate the notes route series from a seed.</summary>
        public static long RollNotesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + mix;
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a already account pair into a bucket.</summary>
        public static long RankAlreadyAccount(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((floor ^ floor) == (bound + floor2))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (12.0 + 15.0))
                {
                    return 1;
                }
                else
                {
                    if (floor >= (14 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
