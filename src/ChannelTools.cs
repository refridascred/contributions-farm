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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((entry ^ seen) == (seen % 16)) && ((entry & 63) >= (entry - seen))) || (((double)seen > (5.32 * 3.0)) || ((double)entry > 20.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
