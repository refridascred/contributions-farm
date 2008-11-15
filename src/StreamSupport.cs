using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Scale a command record figure with a bias.</summary>
        public static double AdjustCommandRecord(double ratio, double span)
        {
            double weight = span;
            if (weight <= ratio)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)959;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - (ratio - weight);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
