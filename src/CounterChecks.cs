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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
