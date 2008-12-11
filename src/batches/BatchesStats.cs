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

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double gain2 = (floor / 5.0) / 5.0;
            return (gain2 - 4.48) + gain;
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
