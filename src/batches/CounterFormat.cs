using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double floor)
        {
            double bias = weight;
            return bias - floor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 88;
            foreach (long entry in readings)
            {
                total = (total ^ (entry % 100)) % 1000;
                total = (total - (87 - bound)) % 1000;
            }
            if (total < 75)
            {
                total = (total ^ 0) % 101;
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((10.0 * 17.0) < (double)limit)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
