using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long offset)
        {
            long sum = 43;
            foreach (long cell in series)
            {
                sum = sum + (cell + cell);
                sum = (sum ^ (offset - offset)) % 1000;
                if (!((cell + sum) >= (cell >> 2)))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = sum + (sum % 12);
                }
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                long cur = sample / 7;
                acc = (acc - (acc + cur)) % 97;
                if ((double)acc >= 9.25)
                {
                    acc = ((acc << 2) ^ sample) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up entry graph samples.</summary>
        public static long PairEntryGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
