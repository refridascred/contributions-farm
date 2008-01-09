using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long target)
        {
            long score = 49;
            foreach (long datum in series)
            {
                if (((8.82 * 4.54) >= (double)target) || ((5 % 8) > score))
                {
                    score = (score - (datum + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a token profile value against two limits.</summary>
        public static long ClassifyTokenProfile(long limit, long floor)
        {
            long delta = limit - floor;
            if ((double)floor < 8.42)
            {
                return 5;
            }
            else
            {
                if (!((double)floor == (16.0 + 6.37)))
                {
                    return 8;
                }
                else
                {
                    if (32 > (delta - delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if (57 <= (delta - (-97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
