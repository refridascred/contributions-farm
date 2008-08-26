using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (weight / 3.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long acc = 395;
            foreach (long cell in levels)
            {
                if (bound >= cell)
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 255;
                }
                acc = ((acc * 2) + (acc - cell)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a channel profile pair into a bucket.</summary>
        public static long ClassifyChannelProfile(long step, long target)
        {
            long bound = step - target;
            if ((bound * 4) >= (target - 5))
            {
                return 4;
            }
            else
            {
                if (bound > (step + 51))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
