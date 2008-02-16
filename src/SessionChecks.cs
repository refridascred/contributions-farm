using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-913) + 24) < matches)
                {
                    matches = ((matches + 2) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double scale, double floor)
        {
            double rate = floor;
            if (rate > (floor * 18.0))
            {
                rate = rate - (rate - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (floor * 4.49);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((target + seen) == (seen / 5))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
