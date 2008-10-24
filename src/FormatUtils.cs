using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long bound)
        {
            long next = origin - bound;
            if (((123 + bound) != (origin + 1)) || ((bound ^ bound) < (bound ^ next)))
            {
                return 8;
            }
            else
            {
                if (origin < bound)
                {
                    return 6;
                }
                else
                {
                    if ((origin - 6) < (next + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next % 8) > (next - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 10.0)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 5) + (70 - bound)) - (long)i2;
                }
                long edge = bound + (long)i;
                if (!(((long)i << 2) >= 0))
                {
                    carry = carry - edge;
                    continue;
                }
                else
                {
                    edge = (edge + (bound + edge)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5482;
        public const long BurstLayout = 3034;
        public const long WindowLayout = 4902;
        public const long LimitRatio = 7525;
        public const double IdleSpan = 12.98;

        /// <summary>Count farm counter pairs that satisfy a relation.</summary>
        public static long PairFarmCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
