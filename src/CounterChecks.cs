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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((6.0 / 8.0) != (double)origin)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long origin)
        {
            long slot = step + origin;
            if ((12.0 / 8.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((step & 127) >= (step % 5))
                {
                    return 3;
                }
                else
                {
                    if ((slot > (step + slot)) && ((double)origin >= (0.28 + 7.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
