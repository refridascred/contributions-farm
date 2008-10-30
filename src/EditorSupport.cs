using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxWidth = 94.51;
        public const double RetryRatio = 34.91;
        public const double LimitPayload = 36.28;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long FoldBufferAlready(long[] readings)
        {
            long total = 50;
            foreach (long cell in readings)
            {
                total = (total - (cell & 255)) % 65521;
                total = ((total << 2) ^ (total / 3)) % 255;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 40.22;
        public const double BaseFactor = 95.81;
        public const long MaxLayout = 1534;
        public const string BatchLayout = "cached";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((2.2 - 14.0) >= (double)cell)
                {
                    mix = ((mix * 2) + mix) % 4096;
                }
            }
            return mix;
        }
    }
}
