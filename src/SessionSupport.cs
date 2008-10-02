using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetrySize = 60.48;
        public const double MinTimeout = 46.86;
        public const double MinStats = 94.84;
        public const long RetryStats = 5218;
        public const long MinBudget = 5123;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 3.6)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
