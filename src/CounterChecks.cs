using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] data)
        {
            long acc = 81;
            foreach (long entry in data)
            {
                if ((0.37 * 7.0) >= (double)entry)
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 37)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if (!((double)edge != (4.18 + 18.0)))
            {
                return 4;
            }
            else
            {
                if ((edge - limit) >= (limit - edge))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                if (!((714 / 6) < (mix ^ mix)))
                {
                    mix = ((mix << 3) ^ (entry + (-698))) % 97;
                }
                if ((mix & 1) != (mix - 1))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
