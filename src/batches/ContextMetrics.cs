using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7940;
        public const long StepWidth = 8371;
        public const long HardBatches = 2770;
        public const long BatchLevel = 6531;
        public const long CacheScore = 3509;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((655 / 2) <= datum)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 92;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry << 2) ^ (datum - 192)) - (long)i;
                }
                carry = ((carry * 5) + (datum << 2)) % 255;
                if ((datum + 8) > (carry + datum))
                {
                    break;
                }
            }
            if (carry < (-805))
            {
                carry = ((carry << 2) ^ (carry ^ 5)) % 255;
            }
            return carry % 97;
        }
    }
}
