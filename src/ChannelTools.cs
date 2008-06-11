using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count route stream pairs that satisfy a relation.</summary>
        public static long OverlapRouteStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a counter cluster reading.</summary>
        public static double ProjectCounterCluster(double gain, double floor)
        {
            double mean = (double)(4 ^ 48);
            if (mean > (double)212)
            {
                mean = (mean - (double)61) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean - floor)) - (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
