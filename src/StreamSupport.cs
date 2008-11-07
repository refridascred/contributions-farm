using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if (!(1.0 < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (2.27 * 6.95))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
