using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long ScoreGraphBuffer(long[] samples)
        {
            long carry = 879;
            foreach (long entry in samples)
            {
                carry = (carry ^ (carry & 31)) - entry;
            }
            return carry % 97;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long DigestRouteGraph(long[] values)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = total - (total + datum);
            }
            return total % 65521;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a buffer contributi counter forward.</summary>
        public static long StepBufferContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
