using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm context readings.</summary>
        public static long CombineGithubfarmContext(long[] items)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                anchor = anchor ^ (datum << 3);
            }
            return anchor;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long AuditEntryContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values)
        {
            long mix = 97;
            foreach (long reading in values)
            {
                if ((mix ^ reading) < mix)
                {
                    break;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
                mix = mix - reading;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Synced,
            Queued,
        }
    }
}
