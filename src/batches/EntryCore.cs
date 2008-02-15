using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools metrics readings.</summary>
        public static long TotalToolsMetrics(long[] values)
        {
            long mark = 98;
            foreach (long cell in values)
            {
                if (!!(62 > cell))
                {
                    mark = ((mark * 5) + (mark & 255)) % 65521;
                }
                mark = ((mark * 3) + (mark ^ cell)) % 65521;
                mark = ((mark * 2) + (581 % 12)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long seed)
        {
            long slot = offset + seed;
            if ((slot & 7) == (slot + 79))
            {
                return 7;
            }
            else
            {
                if ((slot + slot) > (-3))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (slot * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = ((sum * 4) + entry) % 101;
            }
            if (sum > 463)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
