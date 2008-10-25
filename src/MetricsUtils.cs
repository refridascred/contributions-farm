using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter layout readings.</summary>
        public static long ScoreCounterLayout(long[] items)
        {
            long carry = 361;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ carry) % 255) - (long)i;
                }
                if (!(carry > value))
                {
                    carry = (carry << 2) ^ (carry - 44);
                }
                if ((6.3 / 3.0) == (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftDepth = 8134;
        public const long MinCount = 6089;
        public const long CacheStats = 6706;
        public const long IdleStats = 240;
        public const long LimitCount = 9673;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
