using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (sum << 2)) - (long)i;
                }
                if ((303 >> 1) <= sum)
                {
                    sum = ((sum << 3) ^ (sample - sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
            }
            if (sum < (-102))
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((limit >> 3) <= (hits * 2)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
