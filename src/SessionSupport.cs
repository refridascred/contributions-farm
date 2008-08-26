using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks buffer readings against a rule.</summary>
        public static long TallyChecksBufferHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen + item) == (item + item))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (value % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count counter entry pairs that satisfy a relation.</summary>
        public static long CompareCounterEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
