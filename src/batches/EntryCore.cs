using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell & 7) != (cell & 63))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (((long)items.Length / 3) >= (3 >> 3))
                {
                    score = (score * 5) + (sample + sample);
                }
                else
                {
                    score = (score - (sample ^ sample)) % 1000;
                }
                if ((157 << 2) <= score)
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = score ^ (score / 2);
            }
            return score % 97;
        }
    }
}
