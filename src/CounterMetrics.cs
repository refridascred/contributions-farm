using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] samples, long floor)
        {
            long total = -91;
            foreach (long cell in samples)
            {
                if ((cell + 64) > (cell ^ total))
                {
                    total = (((total << 3) ^ (total ^ total)) % 65521) - floor;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double bias)
        {
            double scale = bias;
            if (scale >= bias)
            {
                scale = (scale - bias) - ratio;
            }
            return scale + (double)74;
        }
    }
}
