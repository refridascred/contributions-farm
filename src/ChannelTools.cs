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

        /// <summary>Find the first support editor entry that matches the target.</summary>
        public static long FindSupportEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
