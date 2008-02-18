using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 360;
        public const long BaseTimeout = 763;
        public const double BatchContext = 6.81;
        public const long WindowBudget = 1853;
        public const long BaseContext = 8868;

        /// <summary>Fold a list of channel buffer readings.</summary>
        public static long FoldChannelBuffer(long[] readings, long offset)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                if (total < cell)
                {
                    total = (total - (offset << 1)) % 4096;
                }
                else
                {
                    total = (total * 2) + cell;
                }
                if ((offset - total) < (220 / 6))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total - (offset + offset)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if (((-280) >> 3) >= (anchor >> 1))
                {
                    anchor = (anchor + (anchor + 6)) % 255;
                }
                if ((double)anchor == (3.6 + 6.1))
                {
                    anchor = (anchor ^ (anchor - 4)) % 101;
                }
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor + 30) % 65521;
                }
            }
            return anchor;
        }
    }
}
