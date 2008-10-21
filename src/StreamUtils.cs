using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long mark = 3;
            foreach (long item in readings)
            {
                if ((12.0 + 7.0) < (double)item)
                {
                    mark = mark ^ (mark - mark);
                    continue;
                }
                mark = (mark ^ (item % 10)) % 1000;
                mark = (mark + (25 & 31)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 94;
            foreach (long sample in items)
            {
                sum = (sum ^ ((-469) + sample)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long sum = -936;
            foreach (long sample in levels)
            {
                sum = (sum ^ (sum + sum)) ^ sample;
            }
            if (sum > 576)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            New,
            Dropped,
            Failed,
        }
    }
}
