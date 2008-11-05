using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long anchor = -1;
            foreach (long cell in series)
            {
                if ((cell + anchor) == (4 & 31))
                {
                    anchor = anchor ^ (82 + anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (cell + anchor);
                    anchor = (anchor * 2) + (766 / 2);
                }
                if ((cell / 2) >= (anchor << 3))
                {
                    anchor = (anchor ^ (cell << 2)) % 65521;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 8349;
        public const long HardLayout = 7887;
        public const long IdleRatio = 5612;
        public const long RetryFactor = 4216;
        public const long BurstLayout = 8672;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
