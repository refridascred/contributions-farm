using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long state = 72;
            foreach (long reading in items)
            {
                state = (state + (reading << 2)) % 97;
            }
            if (state > (-758))
            {
                state = (state + (floor ^ floor)) % 97;
            }
            return state;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long RankCommitsCounter(long bound, long target)
        {
            if ((double)target == (6.9 + 4.5))
            {
                return 4;
            }
            else
            {
                if (!((bound % 64) != (bound % 3)))
                {
                    return 0;
                }
                else
                {
                    if (bound < target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
