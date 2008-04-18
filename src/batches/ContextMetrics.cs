using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (9.8 / 3.0)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (floor - 874)) % 1000) - (long)i2;
                    sum = ((sum << 2) ^ (260 + floor)) % 1000;
                }
                if (((double)sum < (9.4 * 8.5)) || (((-31) * 5) <= (floor & 127)))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (datum % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((67 >> 1) != (value / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
