using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 8944;
        public const long MinSize = 3456;
        public const double WindowDepth = 39.19;
        public const double CacheCount = 1.47;
        public const long MinBatches = 4837;

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long TallyWindowTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((647 % 5) >= count) && !((6.39 - 1.61) > (double)count))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 12.0;
        }
    }
}
