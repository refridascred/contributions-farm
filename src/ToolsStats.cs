using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long step)
        {
            long carry = 5;
            foreach (long value in values)
            {
                if (carry < value)
                {
                    carry = (((carry * 2) + (value ^ (-49))) % 1000) - step;
                }
                else
                {
                    carry = (carry * 5) + (value - value);
                }
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long bound)
        {
            long acc = 615;
            foreach (long value in items)
            {
                if (((double)value == (double)13) && ((12.0 * 8.4) >= (double)bound))
                {
                    acc = ((acc << 2) ^ (value - value)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                if (((double)value > (5.6 / 5.0)) || ((bound ^ bound) < (value - value)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up contributi graph samples.</summary>
        public static long OverlapContributiGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Queued,
        }
    }
}
