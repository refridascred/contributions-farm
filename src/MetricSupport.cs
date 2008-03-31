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

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
