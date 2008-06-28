using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long AuditBufferFilterGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item * 4) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (3 >= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((5.1 + 2.31) < (double)matches) && ((datum - seed) < (matches + (long)data.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster tools reading.</summary>
        public static double BlendClusterTools(double weight, double bias)
        {
            double scale = bias;
            if (scale < (weight * 4.8))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
