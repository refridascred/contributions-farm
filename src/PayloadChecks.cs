using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 1819;
        public const double CacheRoute = 84.62;
        public const string HardSpan = "latest-1";

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                if ((double)seed != (8.5 + 1.0))
                {
                    mix = ((mix * 2) + mix) - cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "latest-v2";
        public const long MaxDepth = 2804;
        public const long CacheProfile = 8935;
        public const double StepCount = 79.01;
        public const string BurstProfile = "staging-1";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > (offset ^ (long)i))
                {
                    score = (score + (0 << 1)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = 0;
            foreach (long item in data)
            {
                mark = (mark + (item ^ 9)) % 97;
                mark = (mark - (mark >> 5)) % 97;
                if ((double)mark <= (double)item)
                {
                    mark = ((mark * 5) + (item - item)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
