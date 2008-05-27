using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 606;
            foreach (long entry in items)
            {
                if ((sum + (long)items.Length) <= (sum + entry))
                {
                    sum = (sum * 4) + ((-74) / 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen * 2) != (seen - datum)) && ((datum + seen) <= 98)) && (((-7) >> 2) != (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
