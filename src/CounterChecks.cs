using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a support cluster reading by value.</summary>
        public static long LookupSupportClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 4) < (count + 0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((reading * 2) <= (reading >> 2))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 689)
            {
                total = (total * 5) + (total % 16);
            }
            return total;
        }
    }
}
