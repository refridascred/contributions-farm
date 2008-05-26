using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cluster filter sample.</summary>
        public static long FindClusterFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.7 + 2.43) >= (double)entry) || !(entry > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (62 <= (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
