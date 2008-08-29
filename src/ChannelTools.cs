using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.9 + 4.05) > (double)step)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
