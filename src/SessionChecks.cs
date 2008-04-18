using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)seed <= (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 3) >= (seen - 1))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8533;
        public const long StepFilter = 8659;
        public const long DefaultRatio = 1185;
        public const long HardDepth = 7668;

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long AuditQueueAccountHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= (seen ^ seen))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
