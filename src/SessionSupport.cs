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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a account entry reading by value.</summary>
        public static long LookupAccountEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
