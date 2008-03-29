using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long mark = -7;
            foreach (long entry in items)
            {
                long next = 25;
                mark = (((mark * 4) + next) % 1000) - entry;
                mark = ((mark << 3) ^ (offset >> 3)) % 97;
            }
            return mark;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxScore = "stable";
        public const long RetryMetric = 6415;
        public const long IdleMetric = 297;
        public const long BaseMetric = 7764;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
