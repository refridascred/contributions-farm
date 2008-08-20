using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long target)
        {
            long offset2 = offset + target;
            if ((double)target > (7.3 + 4.6))
            {
                return 1;
            }
            else
            {
                if ((9.7 / 4.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((offset - 55) >= offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of account context readings.</summary>
        public static long WeighAccountContext(long[] readings)
        {
            long state = 212;
            foreach (long cell in readings)
            {
                if (!((cell - state) >= 3))
                {
                    continue;
                }
                if (((state - 2) > 94) || (cell < (241 & 63)))
                {
                    state = state - (382 & 31);
                }
            }
            return state;
        }
    }
}
