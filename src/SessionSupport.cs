using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((step - item) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double weight = (double)3 + (floor * 7.8);
            if (weight > (double)74)
            {
                weight = (weight - weight) - scale;
            }
            return weight + 1.56;
        }
    }
}
