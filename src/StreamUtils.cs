using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long score = 85;
            foreach (long reading in series)
            {
                score = (((score << 2) ^ (seed - 335)) % 255) ^ reading;
            }
            if (score > 771)
            {
                score = (score * 2) + (score / 5);
            }
            return score % 97;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long WeighEditorCommand(long[] values)
        {
            long total = 8;
            foreach (long item in values)
            {
                if ((item & 255) <= 955)
                {
                    total = total - ((-64) >> 3);
                }
                else
                {
                    total = (total << 2) ^ (item & 3);
                }
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 51;
            foreach (long datum in items)
            {
                sum = (sum * 4) + (datum << 1);
                if (!((-852) <= (datum >> 5)))
                {
                    sum = ((sum << 3) ^ 50) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
