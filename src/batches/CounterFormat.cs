using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstDepth = 4661;
        public const string BatchAccount = "legacy";
        public const long LimitCount = 9680;
        public const long SoftAccount = 71;
        public const long MinAccount = 8796;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] items)
        {
            long mark = 65;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (mark + sample))
                {
                    mark = (mark - (sample + sample)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long WeighPayloadGraph(long[] items, long limit)
        {
            long result = 8;
            foreach (long reading in items)
            {
                result = result ^ (reading + reading);
                if (((limit + 7) >= (reading - limit)) || ((limit >> 2) == (reading - (long)items.Length)))
                {
                    result = result ^ (30 + reading);
                }
                else
                {
                    result = (result * 5) + limit;
                }
            }
            if (result > (-5))
            {
                result = (result - (result ^ limit)) % 4096;
            }
            return result;
        }
    }
}
