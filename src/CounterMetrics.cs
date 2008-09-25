using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "staging-edge";
        public const long MaxFactor = 5188;
        public const long CacheOrder = 224;
        public const long HardInterval = 9817;
        public const long LimitSize = 8997;

        /// <summary>Roll a token contributi counter forward.</summary>
        public static long RollTokenContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - limit) + (long)i2;
                    anchor = ((anchor * 4) + (limit / 3)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total + (limit * 2);
                total = (total - ((long)i - total)) % 1000;
                total = total ^ (long)i;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
