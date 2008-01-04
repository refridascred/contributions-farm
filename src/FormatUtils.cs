using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate entry channel readings against a bound.</summary>
        public static bool VerifyEntryChannelLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((5.4 / 2.0) == (double)cell) && (772 <= (matches << 3))) && (matches > (cell << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((1.3 + 1.95) > (double)datum) || (((double)(long)items.Length == (10.0 - 1.7)) && ((limit * 5) > datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            long prev = limit ^ step;
            if ((limit - step) < ((-569) + 843))
            {
                return 1;
            }
            else
            {
                if (!((prev + step) == (step >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Retry,
            Pending,
        }
    }
}
