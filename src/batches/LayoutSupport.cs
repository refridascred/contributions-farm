using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long TallyFarmSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits & 31) <= item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 16.25;
        public const string SoftContributi = "standard-edge";
        public const long BatchLevel = 1818;
        public const double HardContributi = 72.22;
        public const long DefaultDepth = 4859;

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context schema counter forward.</summary>
        public static long SeriesContextSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + (carry - (long)i)) + (long)i2;
                }
                carry = ((carry << 2) ^ bound) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
