using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((868 ^ 597) <= (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (long)levels.Length) % 1000) + entry;
                if (!((limit ^ limit) < result))
                {
                    result = (result - (limit / 8)) % 255;
                }
            }
            if (result > 676)
            {
                result = ((result * 3) + (limit + (-84))) % 101;
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
