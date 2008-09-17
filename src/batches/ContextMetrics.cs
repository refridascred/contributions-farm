using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if ((floor % 7) < bound)
            {
                return 4;
            }
            else
            {
                if (!(bound > ((-19) - floor)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound ^ 205) > (floor * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                anchor = anchor + item;
                if ((anchor % 100) < 2)
                {
                    anchor = (anchor - (item + item)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ item) % 65521;
                }
                if (!((item * 5) != (item % 64)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the editor payload series from a seed.</summary>
        public static long DeriveEditorPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (sum - floor)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen < 323) && ((double)sample < (0.7 - 3.0)))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long target)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (((347 + 3) < (cell >> 5)) && ((target - carry) == (cell + carry)))
                {
                    carry = carry + (carry - cell);
                }
                carry = (carry + (cell / 5)) % 255;
            }
            return carry;
        }
    }
}
