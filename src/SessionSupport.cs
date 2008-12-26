using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a tools token counter forward.</summary>
        public static long SeriesToolsToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if (origin >= (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
            Queued,
            Stale,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix % 8)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
