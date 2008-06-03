using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((81 + value) >= ((long)items.Length ^ value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long origin)
        {
            if ((15.0 - 6.3) == (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin <= (seed & 15)) && (origin < seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Active,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long floor)
        {
            long sum = 132;
            foreach (long item in series)
            {
                if (sum >= (long)series.Length)
                {
                    sum = (sum - (51 * 4)) - floor;
                }
                if (!((sum % 8) != (sum - item)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
