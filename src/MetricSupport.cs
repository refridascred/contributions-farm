using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)27)
            {
                ratio = ratio + (ratio * 6.9);
            }
            else
            {
                ratio = ratio + (gain + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio * 11.0)) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                long next = limit;
                if (((carry - 199) > (sample - limit)) && ((double)carry > (double)limit))
                {
                    next = next ^ carry;
                    carry = (carry * 2) + (next + carry);
                }
                if ((carry ^ sample) < (sample + 67))
                {
                    carry = (carry ^ (limit & 7)) % 4096;
                }
            }
            if (carry < 7)
            {
                carry = ((carry * 4) + (47 ^ limit)) % 4096;
            }
            return carry % 4096;
        }
    }
}
