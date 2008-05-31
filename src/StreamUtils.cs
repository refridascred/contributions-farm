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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
