using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long MeasureToolsLayoutMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long BucketSupportSession(long target, long target2)
        {
            long cur = target ^ target2;
            if ((10.0 * 6.6) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (((target / 7) > 701) && ((target2 + target2) > (target2 * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target2) == (cur + cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long bound)
        {
            long step = offset - bound;
            if (step < (992 & 127))
            {
                return 6;
            }
            else
            {
                if ((double)step < (0.99 / 9.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) == (step * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
