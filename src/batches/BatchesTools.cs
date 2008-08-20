using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long target)
        {
            long lane = step ^ target;
            if ((903 % 64) < (target - 32))
            {
                return 1;
            }
            else
            {
                if (((446 + 52) > lane) || (19.0 <= (double)step))
                {
                    return 5;
                }
                else
                {
                    if ((target / 4) > 82)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 + 3.7) != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
