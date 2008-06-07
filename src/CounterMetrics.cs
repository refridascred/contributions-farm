using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of githubfarm report readings.</summary>
        public static long TotalGithubfarmReport(long[] readings, long seed)
        {
            long carry = 736;
            foreach (long reading in readings)
            {
                if (!((1.3 * 14.0) <= (double)carry))
                {
                    carry = (((carry ^ (carry + 5)) % 97) + reading) + seed;
                }
                else
                {
                    carry = (carry + ((long)readings.Length % 60)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Scale a context session figure with a bias.</summary>
        public static double ProjectContextSession(double scale, double floor)
        {
            double scale2 = 8.19;
            if (scale2 > (scale2 * 4.0))
            {
                scale2 = (scale2 - (double)991) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long state = -6;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (bound % 5)) - datum;
            }
            return state;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
