using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum + 300);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (mix & 63);
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long AuditGraphPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) <= (count - 85))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
