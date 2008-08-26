using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 8426;
        public const long StepOrder = 2233;
        public const double BatchSpan = 52.46;
        public const long MinOrder = 5243;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((sample - sample) < (mark << 3))
                {
                    mark = (mark << 3) ^ (450 & 7);
                }
                if (sample < (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
