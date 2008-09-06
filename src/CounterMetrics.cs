using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((prev - floor) > (floor2 << 3))
            {
                return 0;
            }
            else
            {
                if (((97 + floor) >= (floor2 + 2)) && (28 <= (679 + floor2)))
                {
                    return 1;
                }
                else
                {
                    if ((5.6 > (double)floor2) || ((7 * 3) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 & 255) < (floor2 * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metric commits value.</summary>
        public static double BlendMetricCommits(double rate, double floor)
        {
            double gain = (floor * 1.52) - (rate - rate);
            if (gain < gain)
            {
                gain = gain - (double)5;
            }
            else
            {
                gain = gain + (double)490;
            }
            return gain - (rate / 7.0);
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
