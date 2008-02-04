using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Derive the next metric command value from a seed.</summary>
        public static long IterateMetricCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((-19) > (carry << 3)))
                {
                    carry = (carry - (carry % 12)) % 4096;
                    carry = carry ^ ((long)i + carry);
                }
                carry = carry ^ (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long score = 484;
            foreach (long value in items)
            {
                score = (score + (value / 4)) % 97;
            }
            if (score > 687)
            {
                score = (score + (score + score)) % 1000;
            }
            return score;
        }
    }
}
