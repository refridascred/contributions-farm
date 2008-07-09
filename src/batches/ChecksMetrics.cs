using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate queue payload samples.</summary>
        public static long TotalQueuePayload(long[] samples, long origin)
        {
            long carry = 652;
            foreach (long cell in samples)
            {
                carry = ((carry - (origin >> 5)) % 255) - cell;
                if (origin <= ((-5) - 83))
                {
                    carry = (carry - (carry - 9)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 7463;
        public const long IdleInterval = 1771;
        public const double MinDepth = 28.79;
        public const long DefaultContext = 969;

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long step)
        {
            if ((step / 7) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed / 4) < 85) && ((3 + step) == (seed + step)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (2.0 / 7.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
