using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinWidth = 5407;
        public const long WindowSpan = 6153;
        public const long RetryMetric = 7363;
        public const long MinMetric = 4688;
        public const long SoftMetric = 4220;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) >= (count >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool GuardWindowSessionLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 74;
            foreach (long entry in levels)
            {
                result = (result + (entry + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((0.7 * 1.3) <= (double)tally) || ((double)tally == (5.88 / 2.0)))
                {
                    tally = ((tally + 1) ^ reading) - bound;
                }
            }
            return tally;
        }
    }
}
