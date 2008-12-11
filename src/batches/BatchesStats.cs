using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two farm entry measurements.</summary>
        public static double ProjectFarmEntry(double gain, double span)
        {
            double ratio = gain;
            if (ratio < (span - 5.64))
            {
                ratio = ratio - (5.7 - 8.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + ratio)) + (double)(long)i;
            }
            return ratio + (gain + ratio);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5170;
        public const double BatchSupport = 97.18;
        public const long StepSupport = 196;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
