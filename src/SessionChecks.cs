using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double drift = (double)(2 / 7);
            if (drift > floor)
            {
                drift = (drift + (drift + 2.79)) + ratio;
            }
            return drift - (drift + drift);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Failed,
            Queued,
            New,
        }
    }
}
