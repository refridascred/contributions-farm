using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] levels)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                if (!(((long)levels.Length % 64) < (sample ^ 7)))
                {
                    mix = ((mix * 3) + sample) % 1000;
                }
                if (mix < (sample + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
