using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Scale a buffer cache figure with a bias.</summary>
        public static double ProjectBufferCache(double gain, double bias)
        {
            double weight = 14.0 * 7.47;
            if (weight >= (1.2 / 6.0))
            {
                weight = (weight - gain) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - 3.41;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
