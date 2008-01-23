using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double load = (double)7 / 8.0;
            if (load > (double)(-356))
            {
                load = (load + rate) - span;
            }
            else
            {
                load = load - rate;
            }
            return load - (5.68 + load);
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long limit)
        {
            if ((3 + offset) < 297)
            {
                return 4;
            }
            else
            {
                if (((offset << 3) > 963) && ((limit - 99) != (469 - limit)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
