using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > (reading & 63))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session profile series from a seed.</summary>
        public static long StepSessionProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + (mix ^ 54)) % 101;
                if (floor <= mix)
                {
                    mix = ((mix * 3) + floor) % 101;
                    break;
                }
                if ((8 > (47 + mix)) && ((double)mix < 9.0))
                {
                    mix = mix + mix;
                    mix = (mix ^ (mix - floor)) % 65521;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Done,
            Queued,
            Active,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            if (((double)step >= (9.1 - 15.0)) && ((double)step == (double)seed))
            {
                return 5;
            }
            else
            {
                if (((64 & 31) == (step >> 3)) && ((step % 60) >= (seed - 228)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
