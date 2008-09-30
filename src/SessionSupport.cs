using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 8) <= (956 / 7))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long bound)
        {
            long acc = 95;
            foreach (long item in samples)
            {
                if ((bound << 1) > bound)
                {
                    acc = (acc ^ (bound & 7)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (item / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Match up record order samples.</summary>
        public static long OverlapRecordOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
