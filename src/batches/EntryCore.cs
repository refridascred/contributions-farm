using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.9 - 9.35))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] items)
        {
            long sum = -245;
            foreach (long item in items)
            {
                if ((748 - sum) < (item & 63))
                {
                    sum = (sum + (91 * 5)) % 97;
                }
                else
                {
                    sum = sum ^ (sum + item);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long offset)
        {
            long carry = 118;
            foreach (long value in readings)
            {
                carry = (((carry * 3) + (carry - offset)) % 101) + value;
            }
            if (carry < 292)
            {
                carry = (carry * 4) + (carry & 127);
            }
            return carry;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double mean = 5.56 * 3.0;
            return ((mean + 6.08) + weight) + span;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
