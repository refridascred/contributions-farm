using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] data, long bound)
        {
            long sum = 27;
            foreach (long reading in data)
            {
                sum = (sum ^ (bound + reading)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 912;
        public const double WindowScore = 88.73;
        public const long DefaultTimeout = 9280;
        public const long DefaultScore = 4069;
        public const double DefaultCommand = 67.16;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading + 58) > (hits - origin)) && (origin < (hits * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next token window value from a seed.</summary>
        public static long RollTokenWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor - (anchor >> 1)) % 4096;
                if (((long)i ^ (long)i) > (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ ((long)i >> 3)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ floor;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
