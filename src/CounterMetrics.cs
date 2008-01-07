using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long limit, long bound)
        {
            long edge = limit + bound;
            if (8.1 < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((edge >> 2) > (limit + 639))
                {
                    return 2;
                }
                else
                {
                    if (limit > (9 * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)edge <= 9.0))
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

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mix = 2;
            foreach (long value in readings)
            {
                mix = ((mix * 4) + 5) % 97;
                mix = (mix - value) % 1000;
            }
            return mix % 65521;
        }
    }
}
