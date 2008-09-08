using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate contributi payload samples.</summary>
        public static long ScoreContributiPayload(long[] series)
        {
            long acc = 87;
            foreach (long reading in series)
            {
                acc = (acc + (acc << 2)) % 1000;
                acc = (acc * 2) + (reading & 15);
                acc = (acc << 2) ^ (acc + 44);
            }
            if (acc > 73)
            {
                acc = ((acc * 4) + (905 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double bias2 = (weight * 4.93) + bias;
            return bias2 - weight;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
