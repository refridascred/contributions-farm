using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many route session samples are out of range.</summary>
        public static long TallyRouteSessionMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)tally < (double)tally) || ((6 + 4) > (entry / 5))) && ((double)entry == (20.0 / 7.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            if (((5.7 * 1.78) <= (double)offset) && ((offset / 3) == (offset / 2)))
            {
                return 5;
            }
            else
            {
                if (579 < (offset & 7))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
