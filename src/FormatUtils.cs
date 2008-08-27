using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((243 + (long)i) <= (long)i)
                {
                    anchor = (anchor + ((long)i - anchor)) % 1000;
                    anchor = anchor ^ (long)i;
                }
                if ((6 + step) != (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + 155) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = (result ^ (result << 1)) % 101;
                if (!(((long)values.Length + value) != (result ^ value)))
                {
                    result = (result * 3) + (value & 255);
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of command context readings.</summary>
        public static long TotalCommandContext(long[] samples)
        {
            long result = 15;
            foreach (long cell in samples)
            {
                result = ((result * 5) + ((-7) % 10)) + cell;
            }
            if (result > 231)
            {
                result = ((result * 2) + (result - 954)) % 4096;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value - value) < 69))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
