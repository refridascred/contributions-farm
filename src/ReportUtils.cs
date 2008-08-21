using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long span = bound - limit;
            if (!(span >= bound))
            {
                return 1;
            }
            else
            {
                if ((1.2 + 20.0) >= 8.0)
                {
                    return 4;
                }
                else
                {
                    if ((12.0 * 0.2) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)limit == (double)24) && ((limit - bound) < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor profile readings.</summary>
        public static long DigestEditorProfile(long[] series, long offset)
        {
            long carry = -4;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + offset) - cell;
            }
            return carry % 65521;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value + 375) <= (value << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
