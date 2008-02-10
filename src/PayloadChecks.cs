using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double load = floor - (double)920;
            if (load < rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + load)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double rate = (1.58 - floor) * 3.9;
            if (rate < 6.2)
            {
                rate = (rate - 3.0) - bias;
            }
            else
            {
                rate = rate + (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count == (5.86 * 2.1))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!!((seen / 5) >= (seen >> 4)))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long carry = 369;
            foreach (long value in levels)
            {
                carry = carry - (value + value);
            }
            return carry % 4096;
        }
    }
}
