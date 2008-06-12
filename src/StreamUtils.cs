using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long AuditStreamSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + 6) > (cell << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long sample in series)
            {
                if (!(anchor <= (3 - anchor)))
                {
                    anchor = (anchor - 4) - sample;
                }
                else
                {
                    anchor = (anchor << 2) ^ 426;
                }
                if (anchor < (origin - 4))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (origin - anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)seed == (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
