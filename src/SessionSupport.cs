using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a layout report reading.</summary>
        public static double ScaleLayoutReport(double weight, double offset)
        {
            double weight2 = (double)1 + (double)756;
            if (weight2 > (double)(-19))
            {
                weight2 = (weight2 - 0.4) - offset;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (double)(-9);
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "local-edge";
        public const long HardSchema = 7108;
        public const long BaseTimeout = 4998;
        public const double BurstSchema = 23.18;
        public const double LimitSchema = 12.39;
    }
}
