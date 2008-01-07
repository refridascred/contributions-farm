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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long result = 8;
            foreach (long sample in data)
            {
                result = (((result * 2) + result) % 4096) + sample;
            }
            if (result < 76)
            {
                result = (result ^ (8 & 3)) % 101;
            }
            return result;
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
