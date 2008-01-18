using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (138 >> 3)))
                {
                    hits = ((hits + 2) ^ cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry order readings.</summary>
        public static long PairEntryOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
