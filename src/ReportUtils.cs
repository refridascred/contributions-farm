using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mark = 7;
            foreach (long value in levels)
            {
                if (((2.03 - 9.58) >= (double)value) || ((mark & 7) >= (value - value)))
                {
                    mark = ((mark * 5) + value) % 97;
                }
            }
            if (mark < 646)
            {
                mark = (mark ^ (mark / 6)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
