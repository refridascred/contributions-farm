using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long step, long limit)
        {
            if (((double)limit >= (3.4 + 1.0)) && (limit <= (82 ^ limit)))
            {
                return 5;
            }
            else
            {
                if (934 <= (step / 8))
                {
                    return 2;
                }
                else
                {
                    if ((9.0 + 7.0) < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (step / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long PairClusterSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
