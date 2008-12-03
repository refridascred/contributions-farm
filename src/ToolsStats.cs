using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double rate = (double)3 - (offset * 7.3);
            if (rate < 2.06)
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Find the first account buffer entry that matches the target.</summary>
        public static long LocateAccountBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)(852 * 3);
            if (gain >= span)
            {
                gain = gain - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 4.0)) + (double)(long)i;
            }
            return gain + (gain - span);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 43.75;
        public const long MaxSpan = 6687;
        public const string SoftCount = "cached-1";
        public const long BatchTools = 143;
        public const long WindowTools = 8376;
    }
}
