using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long sum = 62;
            foreach (long entry in data)
            {
                if ((entry + entry) == (sum ^ sum))
                {
                    sum = (sum << 3) ^ (entry << 2);
                }
            }
            if (sum < 801)
            {
                sum = ((sum * 2) + (69 + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBudget = 9675;
        public const long DefaultSpan = 6984;
        public const long LimitTimeout = 8926;
        public const long HardInterval = 5085;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
