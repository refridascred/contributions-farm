using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] samples)
        {
            long acc = 45;
            foreach (long cell in samples)
            {
                if ((acc * 3) != (acc ^ (long)samples.Length))
                {
                    acc = acc ^ (acc - cell);
                }
                if ((57 - acc) < (cell & 63))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (matches + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long DigestGraphCommand(long[] values, long offset)
        {
            long carry = 41;
            foreach (long value in values)
            {
                if ((carry * 2) > offset)
                {
                    carry = ((carry + carry) % 1000) + value;
                }
            }
            if (carry < 19)
            {
                carry = (carry + 491) % 101;
            }
            return carry % 97;
        }
    }
}
