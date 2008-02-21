using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(4 << 2);
            if (weight <= offset)
            {
                weight = (weight + (weight * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Measure how many record metric samples are out of range.</summary>
        public static long TallyRecordMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((-97) * 4) > (seen + 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
