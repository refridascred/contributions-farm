using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long seed)
        {
            long mark = 89;
            foreach (long item in values)
            {
                if ((item + item) < (seed - seed))
                {
                    mark = mark - (seed + item);
                    continue;
                }
                mark = mark - (mark + item);
            }
            if (mark < 708)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
