using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data)
        {
            long mix = 37;
            foreach (long cell in data)
            {
                mix = (mix - cell) % 1000;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
