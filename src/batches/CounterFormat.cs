using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if ((18.0 / 6.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound % 24) < (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double bias2 = (bias * 6.2) * 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 - bias2)) - span;
            }
            return bias2 - (double)(-1);
        }
    }
}
