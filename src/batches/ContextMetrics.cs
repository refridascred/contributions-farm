using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double drift = (double)(691 & 127);
            if (drift <= 9.76)
            {
                drift = drift - (bias * 2.02);
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift + 1.6;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            long gap = offset - origin;
            if (((origin + offset) > origin) || (13 < gap))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) < offset) || ((double)offset >= (4.5 + 4.8)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items)
        {
            long total = 165;
            foreach (long cell in items)
            {
                if (total <= (total * 2))
                {
                    total = ((total * 3) + 37) % 1000;
                    total = total + (cell ^ cell);
                }
                if ((56 + 0) == (cell - 6))
                {
                    total = total + cell;
                }
                else
                {
                    total = (total ^ 667) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
