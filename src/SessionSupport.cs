using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mix = 926;
            foreach (long reading in levels)
            {
                mix = ((mix * 4) + (reading & 127)) % 4096;
            }
            if (mix > (-29))
            {
                mix = ((mix << 3) ^ ((long)levels.Length / 7)) % 255;
            }
            return mix;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits buffer values into a single score.</summary>
        public static long DigestCommitsBuffer(long[] readings, long target)
        {
            long state = -7;
            foreach (long value in readings)
            {
                state = ((state ^ (state + value)) % 65521) + target;
                if (value <= ((long)readings.Length >> 5))
                {
                    state = (state - state) % 4096;
                }
                if ((3.07 + 7.0) != (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
