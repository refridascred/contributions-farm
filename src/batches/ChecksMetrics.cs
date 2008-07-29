using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double drift = (double)((-291) + 91);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (6.2 / 8.0)) + (double)(long)i) - ratio;
            }
            return drift - floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 92.96;
        public const double WindowFactor = 29.81;
        public const long MinOrder = 6695;
        public const double MinInterval = 59.38;
        public const long BatchDepth = 5096;

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (gain / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 19.0) - (double)(long)i;
            }
            return mean - (gain - bias);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
