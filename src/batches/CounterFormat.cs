using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batch command samples.</summary>
        public static long CombineBatchCommand(long[] samples, long offset)
        {
            long state = 53;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (((state << 3) ^ offset) % 1000) - (long)i;
                }
                state = (state ^ sample) % 1000;
            }
            return state % 97;
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
