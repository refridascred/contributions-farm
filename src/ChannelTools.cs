using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "open-edge";
        public const long MaxScore = 4331;
        public const long HardContributi = 5855;
        public const long LimitContributi = 4464;

        /// <summary>Count stream batches pairs that satisfy a relation.</summary>
        public static long CompareStreamBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double load = 3.56;
            if (load < (double)0)
            {
                load = load + (floor - weight);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (load + load);
        }
    }
}
