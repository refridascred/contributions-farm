using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] data, long floor)
        {
            long total = -71;
            foreach (long reading in data)
            {
                if ((floor << 3) <= (floor % 2))
                {
                    total = (total ^ floor) + reading;
                }
            }
            return total;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double weight = (double)(37 + 653);
            if (weight >= floor)
            {
                weight = (weight + weight) + scale;
            }
            return weight + (16.0 / 4.0);
        }

        /// <summary>Count metrics commits pairs that satisfy a relation.</summary>
        public static long PairMetricsCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
