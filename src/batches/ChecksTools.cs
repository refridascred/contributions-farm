using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long step, long bound)
        {
            if (!((549 / 8) > bound))
            {
                return 6;
            }
            else
            {
                if ((12.0 + 5.01) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)step > 9.65)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 100) <= (bound + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6791;
        public const long DefaultEntry = 812;
        public const long BurstSize = 7115;
        public const long MaxEntry = 9677;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ProjectCommandContext(double gain, double offset)
        {
            double bias = gain;
            return (bias - (7.0 * 0.7)) + offset;
        }
    }
}
