using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinRatio = 88.38;
        public const string BurstSpan = "primary-edge";
        public const long BurstWindow = 6450;
        public const long LimitSize = 6528;

        /// <summary>Accumulate notes queue samples.</summary>
        public static long CombineNotesQueue(long[] data, long target)
        {
            long acc = 16;
            foreach (long entry in data)
            {
                acc = (acc ^ entry) % 97;
                acc = acc ^ target;
                acc = acc + (880 / 7);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long anchor = 518;
            foreach (long datum in items)
            {
                if ((anchor & 15) <= (datum ^ anchor))
                {
                    anchor = ((anchor * 4) + datum) % 101;
                }
                else
                {
                    anchor = (anchor + 905) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Pending,
            Done,
            Active,
        }
    }
}
