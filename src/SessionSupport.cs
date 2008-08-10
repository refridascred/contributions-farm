using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) > (datum / 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((25 >> 3) <= matches)
                {
                    matches = ((matches + 3) - value) - limit;
                }
            }
            return matches;
        }
    }
}
