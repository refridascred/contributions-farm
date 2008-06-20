using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardSize = 81.03;
        public const long SoftLevel = 9243;
        public const double StepScore = 54.4;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
