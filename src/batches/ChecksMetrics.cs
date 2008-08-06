using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            if ((double)origin > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((7.56 * 1.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 101) == (origin + 73))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((176 >> 3) > (seen ^ (-1)))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-664) - value) < ((-6) - value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
