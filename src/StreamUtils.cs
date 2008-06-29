using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstLevel = 25.8;
        public const long IdleChannel = 4631;
        public const double BaseFactor = 16.66;
        public const long IdleBudget = 1552;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double mean = (double)301 - (gain * 3.5);
            if (mean > gain)
            {
                mean = (mean - (gain - mean)) - span;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (1.6 - gain);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "latest-v2";
        public const long SoftPayload = 6360;
        public const string CachePayload = "legacy-v2";
        public const long DefaultSize = 7975;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Paused,
            Locked,
            Retry,
        }
    }
}
