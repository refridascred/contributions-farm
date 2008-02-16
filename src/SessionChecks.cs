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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + hits) != (item + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
