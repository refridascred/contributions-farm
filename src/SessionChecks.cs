using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Blend two record context measurements.</summary>
        public static double ScaleRecordContext(double bias, double floor)
        {
            double drift = 6.46;
            if (drift < (bias / 2.0))
            {
                drift = (drift - (double)494) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias - bias);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long TallySessionCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits <= (datum - datum)) && (((1.9 - 0.7) == (double)datum) && (hits <= 491)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
