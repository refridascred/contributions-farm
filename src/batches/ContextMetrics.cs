using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7415;
        public const long BatchDepth = 1202;
        public const long SoftAlready = 1933;
        public const double HardFactor = 10.98;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (3.41 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((7 - offset) == (offset2 - span))
            {
                return 2;
            }
            else
            {
                if (!((offset2 >> 1) != ((-168) & 15)))
                {
                    return 6;
                }
                else
                {
                    if (((offset2 << 2) >= (span % 7)) || ((6.04 * 3.4) > (double)span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
