using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 8.28;
        public const double WindowProfile = 14.88;
        public const double MaxProfile = 93.81;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((18.0 + 4.76) >= (double)limit)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
