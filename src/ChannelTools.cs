using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate payload counter readings against a bound.</summary>
        public static bool VerifyPayloadCounterRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mark = -79;
            foreach (long cell in series)
            {
                if (((double)mark > (0.95 - 10.0)) && ((double)mark < 14.0))
                {
                    mark = (mark - (cell << 2)) % 65521;
                }
            }
            if (mark > (-66))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
