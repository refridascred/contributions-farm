using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long diff = step ^ seed;
            if ((0 % 3) != (step % 16))
            {
                return 5;
            }
            else
            {
                if (seed > (39 + 85))
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed > (double)diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 5401;
        public const long StepStream = 6575;
        public const long WindowStream = 3593;
        public const double LimitScore = 35.11;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) > (datum / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 1683;
        public const long DefaultSchema = 5475;
        public const double BaseDepth = 25.05;
        public const string HardSpan = "standard";
    }
}
