using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double rate = span * 2.5;
            if (rate > span)
            {
                rate = rate + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate - rate)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long offset)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                if ((offset <= (9 + carry)) && ((sample >> 5) <= sample))
                {
                    carry = (carry * 2) + (77 >> 1);
                }
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }
    }
}
