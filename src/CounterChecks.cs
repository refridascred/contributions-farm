using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long acc = 23;
            foreach (long entry in values)
            {
                if (acc > 67)
                {
                    acc = ((acc ^ (entry + acc)) % 65521) - bound;
                }
            }
            if (acc < 9)
            {
                acc = (acc * 5) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long bound)
        {
            long mark = 74;
            foreach (long entry in levels)
            {
                if (!((bound >> 5) < (entry * 5)))
                {
                    mark = mark - bound;
                }
                mark = (mark + (bound << 3)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Locked,
            New,
            Closed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 7) > seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Pending,
            Done,
            Queued,
            New,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
