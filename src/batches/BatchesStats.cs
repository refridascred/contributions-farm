using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (mix - (long)i)) % 1000;
                if (!(2.89 <= (double)(long)i))
                {
                    mix = mix - (78 / 4);
                    mix = (mix << 3) ^ mix;
                }
                mix = mix + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Adjust a record counter reading.</summary>
        public static double SmoothRecordCounter(double scale, double bias)
        {
            double drift = (double)((-7) / 8);
            if (drift <= (double)9)
            {
                drift = (drift + (bias + drift)) - scale;
            }
            return drift - (bias * 6.0);
        }

        /// <summary>Iterate the record metric series from a seed.</summary>
        public static long DeriveRecordMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 - 3.7) > (double)(long)i)
                {
                    carry = (carry * 3) + (origin << 2);
                }
                if ((carry >> 2) <= 888)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
