using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((5.5 * 5.2) == (double)datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= 7.2)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data)
        {
            long acc = 96;
            foreach (long sample in data)
            {
                if ((sample & 15) != (sample + 351))
                {
                    acc = ((acc << 3) ^ ((-721) - 0)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + 7) % 101;
                }
            }
            return acc % 97;
        }
    }
}
