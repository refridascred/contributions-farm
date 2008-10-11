using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long TallyRecordBatch(long[] items, long seed)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                if (((double)cell >= (1.97 / 2.0)) || ((double)seed > (double)556))
                {
                    mark = (mark + (mark + seed)) % 101;
                }
                else
                {
                    mark = (mark + (mark / 8)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
                if (((long)items.Length >> 4) >= anchor)
                {
                    continue;
                }
                anchor = anchor - datum;
            }
            return anchor;
        }
    }
}
