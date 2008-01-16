using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long DigestAccountCommand(long[] samples, long origin)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((anchor * 2) > anchor)
                {
                    anchor = (anchor + 3) + origin;
                }
                if ((value - (-250)) < (anchor / 9))
                {
                    anchor = anchor - (value + 274);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 99;
            foreach (long sample in levels)
            {
                mark = (mark + mark) % 4096;
                mark = (mark ^ mark) % 97;
                if ((mark << 3) >= (sample / 4))
                {
                    mark = (mark + (mark << 2)) % 101;
                }
            }
            return mark;
        }
    }
}
