using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > (count * 3))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Find the first editor metrics entry that matches the target.</summary>
        public static long SeekEditorMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long AuditSupportEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits <= (6.0 * 13.0))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }
    }
}
