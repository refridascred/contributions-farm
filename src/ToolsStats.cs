using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4793;
        public const long BurstFactor = 1327;
        public const long MaxStream = 9159;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((115 >> 3) <= (matches + matches)) || ((2.14 - 7.26) < (double)cell)) && ((long)readings.Length >= (matches - cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema metric reading by value.</summary>
        public static long FindSchemaMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long prev = (carry >> 3) + ((long)i / 8);
                carry = ((carry << 3) ^ prev) % 101;
                carry = (carry ^ (prev - (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
