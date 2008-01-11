using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches < (8.0 + 11.0))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - count) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter token input into a small class.</summary>
        public static long RankCounterToken(long bound, long offset)
        {
            long edge = bound - offset;
            if ((double)bound < (1.06 * 8.0))
            {
                return 6;
            }
            else
            {
                if ((offset / 5) <= (68 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((edge / 2) < (bound + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
