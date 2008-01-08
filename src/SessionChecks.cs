using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long limit)
        {
            long edge = offset + limit;
            if (((limit - limit) >= (edge + limit)) && ((limit + edge) == (limit >> 1)))
            {
                return 3;
            }
            else
            {
                if ((96 >> 5) >= limit)
                {
                    return 2;
                }
                else
                {
                    if (limit < (offset / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - limit) <= edge) && ((3.0 * 6.61) <= (8.9 / 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 331;
        public const long SoftWidth = 9027;
        public const long MaxRatio = 494;
        public const long BurstScore = 4567;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
