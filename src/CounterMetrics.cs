using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mix = 660;
            foreach (long reading in series)
            {
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix + (reading % 3)) % 255;
                }
                if (!((reading + reading) >= (1 - mix)))
                {
                    mix = ((mix << 2) ^ mix) % 255;
                }
                if ((mix + 47) != (reading * 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Closed,
            Retry,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 97.99;
        public const long HardStats = 1401;
        public const long MinCount = 9260;
    }
}
