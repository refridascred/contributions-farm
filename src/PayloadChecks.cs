using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "latest-v2";
        public const string MinCache = "alpha-edge";
        public const long MinFactor = 2618;

        /// <summary>Locate a batch farm reading by value.</summary>
        public static long LookupBatchFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph route entries.</summary>
        public static long TallyGraphRoute(long[] series)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if ((double)cell == (12.0 * 7.49))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if ((4.3 <= (double)cell) && ((double)cell >= 20.0))
                {
                    state = ((state * 4) + (state << 2)) % 255;
                }
                else
                {
                    state = (state * 4) + (47 - state);
                }
                if ((cell & 7) >= (state + cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long target, long seed)
        {
            if (((target % 7) <= (target * 2)) && ((target * 3) != (target >> 2)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((target + 923) < 97)
                    {
                        return 7;
                    }
                    else
                    {
                        if (8 > (target - seed))
                        {
                            return 8;
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
}
