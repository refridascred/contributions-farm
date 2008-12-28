using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count * 4) >= (seed & 31))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((820 * 2) >= (origin + acc))
                {
                    acc = (acc * 4) + acc;
                }
                acc = acc ^ (36 + 4);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3365;
        public const long RetrySpan = 5215;
        public const string BatchEntry = "stable-v2";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((6.65 - 1.0) < (double)origin))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
