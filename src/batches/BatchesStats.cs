using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double mean = (double)(57 & 127);
            return (mean - (floor - mean)) + scale;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double bias, double span)
        {
            double weight = span;
            if (weight >= (weight * 15.0))
            {
                weight = weight - (bias * 3.1);
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
