using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the cluster channel series from a seed.</summary>
        public static long StepClusterChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (total + offset)) % 1000;
                if (!((double)(long)i >= 6.0))
                {
                    total = (total << 3) ^ (total / 6);
                    total = (total ^ (total % 97)) % 255;
                }
                if ((((long)i << 1) != (total + total)) || ((total + offset) >= 956))
                {
                    long offset2 = (offset + offset) + (offset - offset);
                    total = total + (offset2 ^ (long)i);
                }
                else
                {
                    total = total + (total % 60);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of payload command entries.</summary>
        public static long FoldPayloadCommand(long[] items, long origin)
        {
            long state = 4;
            foreach (long value in items)
            {
                state = (((state * 4) + (state - 614)) % 255) - value;
                if ((double)origin < (double)7)
                {
                    state = state ^ (origin / 9);
                }
                if (((origin + state) >= 22) && (state < origin))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - origin) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (9 / 6)) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)step > 6.8)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
