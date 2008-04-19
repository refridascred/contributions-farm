using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((-7) * 2) >= (value - value))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long offset)
        {
            if ((double)offset <= (0.3 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((2.1 * 15.0) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > 10.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset < (2.1 - 9.5)) && ((86 >> 1) >= (offset << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
