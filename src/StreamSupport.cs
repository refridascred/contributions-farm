using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard";
        public const string LimitCount = "staging-edge";
        public const string BatchRatio = "primary-1";
        public const long WindowSpan = 9755;

        /// <summary>Fold a list of buffer batch readings.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long score = 542;
            foreach (long value in readings)
            {
                score = (score - (-799)) % 1000;
                if ((score < (score + score)) && ((value + 328) <= value))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
