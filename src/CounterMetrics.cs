using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long result = 68;
            foreach (long reading in series)
            {
                result = (result ^ (reading + (-634))) % 65521;
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - ((long)series.Length + reading)) % 97) ^ (long)i;
                }
                result = (result + (result + result)) % 97;
            }
            if (result > 96)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next tools metric value.</summary>
        public static double BlendToolsMetric(double gain, double floor)
        {
            double bias = (double)(6 & 15);
            if (bias <= gain)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (floor * 7.0)) + (double)(long)i;
            }
            return bias - (double)8;
        }
    }
}
