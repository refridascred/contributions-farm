using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long state = 31;
            foreach (long value in data)
            {
                if (((state << 2) > (value + value)) || ((target - 392) >= (value ^ value)))
                {
                    state = ((state << 2) ^ (state * 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((0.68 / 5.0) == (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double drift = (scale + scale) / 3.0;
            if (drift < drift)
            {
                drift = (drift - 8.0) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 4.3;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
