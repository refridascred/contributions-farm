using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long BucketClusterBuffer(long step, long target)
        {
            if (!((target ^ target) != (step ^ step)))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (double)target) || (4 >= (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (target + anchor)) % 255;
                if (((target & 255) < sample) || ((double)target == (0.9 + 9.63)))
                {
                    break;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitScore = 2252;
        public const string SoftSpan = "latest";
        public const long LimitDepth = 8322;

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
