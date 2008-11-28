using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next farm record value.</summary>
        public static double ScaleFarmRecord(double weight, double bias)
        {
            double gain = (bias - bias) + (weight - weight);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Combine cache support values into a single score.</summary>
        public static long CombineCacheSupport(long[] data)
        {
            long result = 243;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result << 3) ^ (long)i) % 4096;
                }
                result = ((result << 2) ^ (value - 818)) % 65521;
            }
            return result;
        }

        /// <summary>Count stats already pairs that satisfy a relation.</summary>
        public static long CompareStatsAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
