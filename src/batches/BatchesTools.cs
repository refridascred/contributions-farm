using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double weight = (double)(-68) / 5.0;
            if (weight >= (double)87)
            {
                weight = (weight + (scale / 5.0)) + offset;
            }
            return weight + (scale - scale);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long result = 133;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + sample) ^ (long)i) - offset;
                }
                result = (result - ((-512) - sample)) % 65521;
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double drift = (double)86;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (span - 11.0)) + (double)(long)i) - gain;
            }
            return drift + (double)9;
        }
    }
}
