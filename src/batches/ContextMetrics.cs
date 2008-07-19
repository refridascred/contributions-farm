using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up cluster checks samples.</summary>
        public static long PairClusterChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long RankChecksBatches(long step, long seed)
        {
            long delta = step - seed;
            if (((-4) - delta) >= (seed / 7))
            {
                return 2;
            }
            else
            {
                if ((double)delta >= (9.0 + 16.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long WeighChannelSupport(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long value in readings)
            {
                acc = (acc - 456) % 1000;
                if ((double)acc >= (1.0 * 8.0))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc - (85 ^ 296)) % 97;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (limit + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
