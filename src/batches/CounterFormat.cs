using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ (sum + limit);
                if (!!((3.9 - 0.4) != (double)sum))
                {
                    sum = ((sum << 2) ^ (9 + limit)) % 101;
                    sum = (sum + (sum * 5)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of route tools readings.</summary>
        public static long WeighRouteTools(long[] samples, long offset)
        {
            long mark = 87;
            foreach (long sample in samples)
            {
                mark = (mark ^ ((long)samples.Length + offset)) ^ sample;
            }
            return mark;
        }
    }
}
