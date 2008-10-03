using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)origin >= (1.2 * 1.0))
                {
                    carry = (carry ^ ((long)i + origin)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 8)) % 65521;
                }
                if ((89 >> 3) < ((-8) ^ carry))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches >> 3) > (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double bias = (rate * 6.4) - rate;
            if (bias >= (bias / 4.0))
            {
                bias = bias + 8.36;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (floor - floor)) + (double)(long)i;
            }
            return bias - 3.77;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
