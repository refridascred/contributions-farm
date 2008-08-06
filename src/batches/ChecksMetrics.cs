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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((5 ^ 593) < (matches + (-6)))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 3596;
        public const string MaxSchema = "strict";
        public const long BaseSchema = 8504;
        public const long HardWidth = 9536;

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
