using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long DigestQueueLayout(long[] values)
        {
            long mix = 992;
            foreach (long sample in values)
            {
                if (sample < (21 / 6))
                {
                    mix = (mix * 5) + (mix >> 3);
                }
            }
            if (mix > 2)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Draft,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Count the stream batch entries that pass the check.</summary>
        public static long TallyStreamBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((38 > item) || (((hits + item) <= item) || ((3.4 - 2.98) == (double)item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes checks entry stays within the limit.</summary>
        public static bool GuardNotesChecksRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
