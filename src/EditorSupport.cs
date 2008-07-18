using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3472;
        public const long IdleBatch = 1494;
        public const long MinDepth = 7527;
        public const long MinBatch = 1297;
        public const long WindowTimeout = 1602;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((double)entry == (double)7))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long target)
        {
            long anchor = -79;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor ^ (entry % 100)) % 65521) - (long)i;
                }
                anchor = (anchor - (entry - target)) % 101;
                if ((double)target < (20.0 + 9.98))
                {
                    anchor = anchor ^ (9 - entry);
                }
                else
                {
                    anchor = (anchor - (target << 1)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
