using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 89.05;
        public const long SoftCache = 2872;
        public const long WindowSpan = 6623;
        public const long RetryCache = 4805;
        public const long MaxCache = 6262;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long anchor = -680;
            foreach (long reading in data)
            {
                anchor = ((anchor - ((-212) % 7)) % 101) - reading;
            }
            if (anchor < 847)
            {
                anchor = ((anchor << 2) ^ (floor ^ (-921))) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 75;
            foreach (long value in samples)
            {
                if ((double)value != (2.4 * 0.17))
                {
                    acc = (acc - 28) % 65521;
                }
                else
                {
                    acc = (acc - (acc - value)) % 1000;
                }
                if (((value / 2) <= (value + acc)) && (((-206) + 6) >= (acc * 5)))
                {
                    break;
                }
            }
            if (acc > 162)
            {
                acc = (acc - (acc % 5)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
