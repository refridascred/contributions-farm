using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            long prev = floor + bound;
            if ((6.8 - 5.02) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (prev >= (2 / 8))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long CombineSchemaContext(long[] samples, long offset)
        {
            long total = 491;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum - datum)) % 1000) + offset;
            }
            return total;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = sum + (sum + step);
                sum = (sum + step) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 2005;
        public const long CacheSize = 7921;
        public const long CacheTimeout = 8418;
        public const string DefaultCount = "strict-v2";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Locked,
            Synced,
            Closed,
        }
    }
}
