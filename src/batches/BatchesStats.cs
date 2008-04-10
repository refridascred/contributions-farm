using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a checks buffer sample.</summary>
        public static long SeekChecksBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long state = 873;
            foreach (long item in readings)
            {
                state = (((state - (981 >> 5)) % 101) - item) - seed;
            }
            return state;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 - (bias - 8.0)) + (double)(long)i) + scale;
            }
            return bias2 - (bias2 + bias);
        }

        /// <summary>Check that every githubfarm metrics entry stays within the limit.</summary>
        public static bool VerifyGithubfarmMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
