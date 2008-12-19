using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long target)
        {
            if (((8 >> 2) == (step + target)) && ((5.3 / 5.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step >> 3) <= step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long seed)
        {
            long edge = limit - seed;
            if (((seed + edge) < edge) && ((double)seed >= (6.21 - 7.24)))
            {
                return 4;
            }
            else
            {
                if ((edge - edge) > (seed + 9))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
