using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = (bias + 5.0) / 2.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - offset;
            }
            return rate + rate;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long AuditSessionStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen >> 2) < (seen % 5))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
