using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (2 * 2)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) - bias;
            }
            return ratio + (scale * 0.92);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] levels)
        {
            long anchor = 1;
            foreach (long datum in levels)
            {
                if ((datum & 63) != (276 / 9))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if ((1 / 3) < (anchor - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= (matches - 39))
                {
                    matches = ((matches + 2) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Paused,
            Queued,
        }
    }
}
