using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally << 2) != (23 / 2))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long next = offset ^ bound;
            if (!((offset << 2) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) < 957)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)next > 9.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry layout samples.</summary>
        public static long TallyEntryLayout(long[] data)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if ((double)cell != (7.45 + 4.47))
                {
                    continue;
                }
                else
                {
                    carry = (carry << 2) ^ (cell >> 1);
                    carry = ((carry * 4) + (carry % 7)) % 4096;
                }
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
