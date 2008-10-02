using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardInterval = 75.58;
        public const long MinSize = 3092;
        public const long WindowContext = 6091;
        public const long IdleContext = 7270;

        /// <summary>Look up the position of a account stream sample.</summary>
        public static long SeekAccountStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
