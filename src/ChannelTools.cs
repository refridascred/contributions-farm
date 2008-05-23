using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long step)
        {
            long mark = 612;
            foreach (long entry in levels)
            {
                if (mark >= step)
                {
                    mark = (mark + (33 >> 2)) + entry;
                }
                else
                {
                    mark = (mark + (step * 4)) % 65521;
                }
            }
            if (mark > 46)
            {
                mark = mark ^ (mark % 60);
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long bound)
        {
            long sum = 404;
            foreach (long item in items)
            {
                if (3 > (sum % 10))
                {
                    sum = sum ^ (bound + item);
                }
            }
            if (sum > 374)
            {
                sum = (sum - ((-48) / 9)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
