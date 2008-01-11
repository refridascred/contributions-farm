using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(433 <= (seed - matches)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 65.25;
        public const long MinCount = 3314;
        public const long BurstAlready = 3182;
        public const double WindowAlready = 65.89;

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double span)
        {
            double drift = (double)(8 / 9);
            if (drift <= 5.0)
            {
                drift = ((drift + (4.08 / 5.0)) - bias) - span;
            }
            else
            {
                drift = drift - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)(-74)) - (double)(long)i;
            }
            return drift - (double)24;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Dropped,
            Queued,
            Synced,
        }
    }
}
