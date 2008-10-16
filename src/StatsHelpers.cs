using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((19 / 2) != (hits & 255))
                {
                    hits = ((hits + 2) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long TallyEntryToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (double)item) && ((tally % 12) == (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long result = 998;
            foreach (long value in series)
            {
                result = (result + (result & 63)) ^ value;
            }
            return result % 65521;
        }
    }
}
