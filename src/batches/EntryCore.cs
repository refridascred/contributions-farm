using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two graph contributi measurements.</summary>
        public static double ScaleGraphContributi(double weight, double bias)
        {
            double drift = 2.0 - (double)1;
            if (drift <= (drift / 5.0))
            {
                drift = (drift - (drift * 7.0)) + weight;
            }
            else
            {
                drift = drift + (drift / 2.0);
            }
            return drift + (drift - bias);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5486;
        public const long WindowBatch = 8345;
        public const long HardBatch = 7291;
        public const double IdleBatch = 81.86;
        public const double CacheBatch = 50.4;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
