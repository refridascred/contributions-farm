using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile token entry stays within the limit.</summary>
        public static bool VerifyProfileTokenRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batch filter values into a single score.</summary>
        public static long FoldBatchFilter(long[] samples, long bound)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                if ((entry + mark) > (mark << 2))
                {
                    mark = ((mark * 2) + mark) + bound;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
