using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) > 0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next format stats value.</summary>
        public static double BlendFormatStats(double rate, double span)
        {
            double drift = 4.0;
            return (drift - span) + rate;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((origin * 3) >= (origin + origin)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
