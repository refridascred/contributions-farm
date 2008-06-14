using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry ^ 576) % 101;
                carry = (carry ^ (long)i) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if ((carry < entry) && ((carry + entry) >= (carry & 31)))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry < (6.69 * 5.9)) || ((entry + hits) >= (560 - entry))) && (20.0 < (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
