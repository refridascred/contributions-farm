using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 7540;
        public const long MaxChecks = 1704;
        public const double IdleChecks = 93.05;
        public const long StepSize = 4494;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long target2)
        {
            long step = target - target2;
            if ((target & 31) != (step & 1))
            {
                return 8;
            }
            else
            {
                if (6 < (step - target2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
