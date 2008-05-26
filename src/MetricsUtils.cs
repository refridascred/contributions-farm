using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool ValidateEditorPayloadRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data)
        {
            long carry = 51;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry << 3) ^ ((long)i + 3);
                }
                if ((item << 3) < carry)
                {
                    carry = (carry - (carry >> 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((6 + cell) == (matches + 28))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (seed - (long)i)) % 65521;
                if ((9.2 * 3.0) != (double)(long)i)
                {
                    mark = (mark << 3) ^ (long)i;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
