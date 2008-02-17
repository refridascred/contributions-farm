using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                result = (result * 5) + item;
                result = (result ^ (item % 10)) % 4096;
            }
            if (result < 68)
            {
                result = result + (result ^ result);
            }
            return result % 4096;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long seed)
        {
            long total = 661;
            foreach (long sample in levels)
            {
                total = ((total - total) + sample) - seed;
                if ((2.6 * 8.7) == (double)total)
                {
                    total = (total * 5) + 4;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                if ((sample << 1) < (sample + sample))
                {
                    anchor = (anchor << 3) ^ 420;
                }
                else
                {
                    anchor = (anchor + (offset - (-930))) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + offset;
            }
            return anchor;
        }
    }
}
