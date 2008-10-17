using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double weight = gain;
            return (weight + 1.0) + span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long result = 51;
            foreach (long sample in levels)
            {
                result = ((result * 2) + (result ^ sample)) % 65521;
            }
            if (result > 5)
            {
                result = (result - (result ^ result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if (origin <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (((edge - offset) < (origin * 3)) || ((860 + origin) < 26))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
