using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (item - 933))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double load = (double)8 + (double)427;
            if (load > (double)463)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + (1.0 + rate);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
