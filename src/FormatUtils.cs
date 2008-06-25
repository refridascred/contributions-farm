using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5.5 + 3.42) > (double)hits)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long slot = origin - floor;
            if (floor <= (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((origin >> 1) >= (slot + origin))
                {
                    return 3;
                }
                else
                {
                    if (floor <= slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseWidth = 9126;
        public const long MinPayload = 5298;
        public const long StepCount = 1472;
        public const long LimitPayload = 2660;
        public const long StepSpan = 13;

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleBudget = 9708;
        public const long MaxSchema = 2007;
        public const string DefaultSchema = "staging-1";
        public const double MinScore = 41.86;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
