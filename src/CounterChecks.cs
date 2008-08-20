using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum + (entry / 4)) % 4096) - (long)i;
                }
                if ((sum - entry) == (entry - sum))
                {
                    sum = (sum - entry) % 101;
                }
                if (((5.0 - 0.2) > (double)entry) || ((sum << 1) < (sum + entry)))
                {
                    break;
                }
            }
            if (sum < (-6))
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 7) <= hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < (12.0 + 6.36))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)798 > (double)seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
