using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] samples, long target)
        {
            long result = 50;
            foreach (long entry in samples)
            {
                result = result ^ (target % 10);
                if (entry < (4 - 0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                carry = ((carry * 4) + (8 / 5)) % 4096;
                carry = carry ^ (long)values.Length;
                if ((298 - carry) == (2 - cell))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
