using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
            public string Rank { get; set; } = "";
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

        /// <summary>Combine filter schema values into a single score.</summary>
        public static long ScoreFilterSchema(long[] values)
        {
            long carry = 28;
            foreach (long datum in values)
            {
                if ((carry - carry) >= (carry + carry))
                {
                    carry = carry + (carry + datum);
                }
            }
            if (carry > 55)
            {
                carry = (carry + (carry >> 5)) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of cache format entries.</summary>
        public static long DigestCacheFormat(long[] readings)
        {
            long sum = 990;
            foreach (long reading in readings)
            {
                sum = (sum + reading) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
