using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((7.5 * 13.0) >= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long step)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((reading / 3) <= (reading & 31))
                {
                    state = ((state * 3) + (state * 4)) - step;
                }
                else
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            if (state > 196)
            {
                state = state + (state & 127);
            }
            return state % 97;
        }

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long MeasureReportFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "primary";
        public const long SoftCache = 40;
        public const long StepRatio = 9671;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
