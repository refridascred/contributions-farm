using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 66;
            foreach (long reading in data)
            {
                if (((8.9 + 12.0) >= (double)reading) && ((double)reading == (2.0 + 19.0)))
                {
                    anchor = (anchor + (anchor >> 3)) % 101;
                }
                if ((247 + reading) >= (anchor << 2))
                {
                    break;
                }
            }
            if (anchor > (-460))
            {
                anchor = ((anchor << 3) ^ (17 + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first farm support entry that matches the target.</summary>
        public static long FindFarmSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
