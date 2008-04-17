using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double mean = bias;
            return mean - bias2;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 63.64;
        public const string MinFilter = "local-v2";
        public const long StepFilter = 4361;
        public const long BaseSize = 3592;
    }
}
