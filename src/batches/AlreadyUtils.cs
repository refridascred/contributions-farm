using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 83.06;
        public const long BatchSpan = 9095;
        public const double SoftStats = 79.47;

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double mean = rate;
            if (mean < (5.2 / 4.0))
            {
                mean = mean - (double)384;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (double)4;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 40.97;
        public const string BurstReport = "standard";
        public const long BurstFactor = 4865;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + 210) < tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
