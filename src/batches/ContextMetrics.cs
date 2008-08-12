using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank already support input into a small class.</summary>
        public static long ClassifyAlreadySupport(long bound, long seed)
        {
            if ((double)bound == (3.7 + 5.4))
            {
                return 8;
            }
            else
            {
                if (((bound % 8) > (bound >> 2)) || ((seed * 2) >= (seed % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (seed ^ seed)) && ((705 - bound) == (bound + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed ^ 3) != (bound % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a record report counter forward.</summary>
        public static long SeriesRecordReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 * 7.4) > (double)bound)
                {
                    break;
                }
                if (((bound + mark) == (263 - bound)) && (mark >= (long)i))
                {
                    mark = ((mark * 2) + ((long)i / 5)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = (carry - (carry >> 4)) % 255;
                carry = (carry + (carry >> 5)) % 101;
                if ((seed << 1) <= carry)
                {
                    carry = (carry + (item - carry)) % 1000;
                }
                else
                {
                    carry = carry + (item + carry);
                }
            }
            if (carry < 416)
            {
                carry = carry ^ 9;
            }
            return carry % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((2.4 * 2.81) != (double)seen))
                {
                    seen = ((seen + 2) + sample) + offset;
                }
            }
            return seen;
        }
    }
}
