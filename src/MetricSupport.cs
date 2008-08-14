using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double ratio = (1.3 * 0.04) + bias;
            if (ratio >= (ratio / 9.0))
            {
                ratio = (ratio + bias) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio * 1.58)) + (double)(long)i;
            }
            return ratio - 0.7;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
