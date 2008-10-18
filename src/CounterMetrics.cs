using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                score = ((score ^ (87 / 9)) % 97) + reading;
            }
            if (score < 6)
            {
                score = (score ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of session batches readings.</summary>
        public static long OverlapSessionBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double gain = (double)((-1) + 4);
            if (gain > gain)
            {
                gain = ((gain + gain) - weight) - offset;
            }
            return gain - (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest-edge";
        public const long BatchFarm = 8491;
        public const double CacheDepth = 54.45;
        public const long StepFarm = 3373;
        public const long BurstFarm = 9259;
    }
}
