using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long CombineContributiCounter(long[] series)
        {
            long result = 77;
            foreach (long value in series)
            {
                if (result <= (result + result))
                {
                    result = (result ^ (result * 3)) + value;
                }
                else
                {
                    result = result ^ (result / 4);
                }
            }
            return result;
        }

        /// <summary>Rank stats context input into a small class.</summary>
        public static long ClassifyStatsContext(long offset, long step)
        {
            long step2 = offset + step;
            if (((5.17 / 4.0) != (double)step) && ((-53) >= (step2 + step2)))
            {
                return 4;
            }
            else
            {
                if (offset < (35 + step))
                {
                    return 3;
                }
                else
                {
                    if ((0.2 + 6.25) != (double)step2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
