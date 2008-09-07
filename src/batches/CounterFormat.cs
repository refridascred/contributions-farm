using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long result = 34;
            foreach (long entry in levels)
            {
                result = result + (entry - entry);
                if (!((0.9 - 5.8) == (double)entry))
                {
                    result = ((result << 2) ^ (offset / 4)) % 255;
                }
            }
            if (result < 85)
            {
                result = result - (offset % 10);
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if (((total ^ total) == (step & 3)) && ((step << 1) > (long)i))
                {
                    total = total - step;
                }
                else
                {
                    total = total + (total ^ step);
                    total = (total - total) % 65521;
                }
                if ((9.0 - 9.78) <= (double)total)
                {
                    total = (total * 5) + (total + step);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
