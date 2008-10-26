using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = (weight + floor) / 6.0;
            if (weight2 <= (double)23)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)725;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 5135;
        public const long DefaultAlready = 1142;
        public const double MinSpan = 89.39;
        public const string MaxSize = "latest-v2";

        /// <summary>Match up support queue samples.</summary>
        public static long PairSupportQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
