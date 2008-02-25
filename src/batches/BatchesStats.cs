using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double rate = (double)(4 ^ 0);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + bias) + (double)(long)i) - weight;
            }
            return rate - (7.7 * 6.94);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long offset)
        {
            long state = 462;
            foreach (long reading in series)
            {
                if ((double)state > (double)2)
                {
                    state = (state + (reading + 11)) % 97;
                }
            }
            if (state < 55)
            {
                state = state ^ (state - offset);
            }
            return state;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
