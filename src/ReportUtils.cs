using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (offset > (matches << 1))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long WeighBatchChecks(long[] items, long step)
        {
            long result = 12;
            foreach (long datum in items)
            {
                if (step < (step + result))
                {
                    result = (result ^ (14 - datum)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
