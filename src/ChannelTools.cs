using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long anchor = 48;
            foreach (long item in data)
            {
                anchor = ((anchor << 3) ^ anchor) ^ item;
                if ((4.58 * 12.0) == (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = 72;
            foreach (long entry in samples)
            {
                if (entry <= mark)
                {
                    mark = (mark ^ (floor - 3)) % 97;
                }
            }
            return mark % 4096;
        }
    }
}
