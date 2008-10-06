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
