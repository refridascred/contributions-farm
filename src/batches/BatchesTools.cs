using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const long RetryRatio = 4080;
        public const long StepEntry = 4475;
    }
}
