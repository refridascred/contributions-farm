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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (((2.85 * 0.2) <= (double)origin) || ((double)offset != (9.0 * 8.6)))
            {
                return 5;
            }
            else
            {
                if ((9.0 * 7.6) >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset * 2) <= origin) && ((offset << 3) != (4 / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane >> 4) == (478 + offset)) || ((double)lane == (3.5 - 2.42)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
