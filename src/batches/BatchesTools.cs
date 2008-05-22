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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
