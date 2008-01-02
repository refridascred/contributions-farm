using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream account samples.</summary>
        public static long FoldStreamAccount(long[] series, long offset)
        {
            long mix = 650;
            foreach (long item in series)
            {
                if (((item * 2) <= offset) && ((16.0 + 10.0) <= (double)item))
                {
                    mix = mix ^ (offset - offset);
                }
            }
            if (mix < 14)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            New,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample & 3) != (step - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
