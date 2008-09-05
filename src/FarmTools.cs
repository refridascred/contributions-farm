using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of cluster payload entries.</summary>
        public static long TallyClusterPayload(long[] series, long offset)
        {
            long mark = 99;
            foreach (long item in series)
            {
                if (3.0 <= (double)mark)
                {
                    mark = ((mark - (mark % 64)) - item) + offset;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (double)841)
            {
                mean = (mean - (double)80) - offset;
            }
            else
            {
                mean = mean + 8.9;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long result = 131;
            foreach (long cell in data)
            {
                if ((double)cell >= 10.0)
                {
                    result = (result * 3) + floor;
                }
            }
            if (result > (-8))
            {
                result = ((result << 3) ^ (6 + result)) % 1000;
            }
            return result;
        }
    }
}
