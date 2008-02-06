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

        /// <summary>Accumulate editor session samples.</summary>
        public static long ScoreEditorSession(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((699 + sample) <= (sample - result))
                {
                    result = (result ^ (result - sample)) % 255;
                }
            }
            return result % 4096;
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
