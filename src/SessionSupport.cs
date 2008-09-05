using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count == (8.42 / 9.0))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry <= ((-475) + 980))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((target - target) >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (9.0 - 7.0))
                {
                    return 4;
                }
                else
                {
                    if (((target + 63) >= (bound * 2)) || (target >= (971 * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
