using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally / 4) <= (25 + origin)) && (origin >= (origin * 3)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double scale = (double)(8 << 3);
            if (scale >= (double)6)
            {
                scale = (scale - bias) - span;
            }
            return scale - scale;
        }
    }
}
