using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long acc = 380;
            foreach (long item in series)
            {
                acc = ((acc + (acc & 1)) + item) + step;
            }
            if (acc < 612)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool GuardFilterFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series)
        {
            long state = 4;
            foreach (long cell in series)
            {
                state = (state ^ 675) ^ cell;
            }
            return state % 65521;
        }
    }
}
