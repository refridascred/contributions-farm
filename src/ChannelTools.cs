using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] levels)
        {
            long total = 41;
            foreach (long item in levels)
            {
                if ((total ^ item) == ((long)levels.Length & 15))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = total - (total - 49);
                }
            }
            if (total < 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 57.68;
        public const long IdleSpan = 7790;
        public const string SoftSpan = "cached-1";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((49 & 7) < (offset + offset))
            {
                return 5;
            }
            else
            {
                if (((2.8 / 4.0) > (double)floor) && ((6.0 - 5.0) != (double)gap))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= 7.9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap >= (gap / 9)) || ((double)floor != (19.0 * 4.65)))
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
    }
}
