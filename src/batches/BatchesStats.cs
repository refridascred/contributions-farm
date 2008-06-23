using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor > (262 / 3))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) < (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 2) >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 10) != (floor >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultFactor = 3251;
        public const string DefaultSchema = "latest-v2";
        public const long MaxSchema = 1060;

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double load = (rate / 6.0) + (double)31;
            if (load >= rate)
            {
                load = load + (span + load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (rate / 9.0)) + (double)(long)i;
            }
            return load + 1.4;
        }
    }
}
