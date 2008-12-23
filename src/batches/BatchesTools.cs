using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of context batches readings.</summary>
        public static long CompareContextBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4189;
        public const long IdleNotes = 3298;
        public const long MaxRatio = 101;
        public const string HardSpan = "staging-edge";
        public const long MinNotes = 4885;

        /// <summary>Blend two profile commits measurements.</summary>
        public static double BlendProfileCommits(double ratio, double floor)
        {
            double weight = (double)(53 << 2);
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 19.0) - (double)(long)i) + ratio) + floor;
            }
            return weight - (double)852;
        }
    }
}
