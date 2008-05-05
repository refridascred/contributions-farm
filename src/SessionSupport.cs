using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit token payload readings against a rule.</summary>
        public static long AuditTokenPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= (target * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Draft,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Blend two report format measurements.</summary>
        public static double BlendReportFormat(double bias, double span)
        {
            double scale = span;
            if (scale > (bias + 5.8))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias * 2.0)) - (double)(long)i;
            }
            return scale - bias;
        }
    }
}
