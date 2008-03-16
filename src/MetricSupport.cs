using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((cell + cell) >= (85 + cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double offset)
        {
            double weight = offset;
            if (weight > (weight * 16.0))
            {
                weight = (weight - offset) - rate;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (double)0;
        }
    }
}
