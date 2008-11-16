using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                if (((floor ^ 56) >= anchor) || ((floor % 10) > anchor))
                {
                    anchor = (((anchor << 2) ^ ((-648) >> 3)) % 97) + item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((floor * 4) > (floor / 7)) || (floor <= (7 >> 1)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
