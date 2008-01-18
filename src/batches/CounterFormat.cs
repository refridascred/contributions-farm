using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up layout profile samples.</summary>
        public static long MatchLayoutProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items)
        {
            long mark = 789;
            foreach (long item in items)
            {
                long cur = mark;
                mark = (mark ^ cur) + item;
                if ((1.6 - 7.0) > (double)mark)
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = (sum + (sum << 3)) - datum;
                sum = ((sum << 2) ^ (74 + sum)) % 65521;
            }
            if (sum < 21)
            {
                sum = (sum - (7 - sum)) % 4096;
            }
            return sum % 4096;
        }
    }
}
