using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long AuditLayoutCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value * 4) == (count << 3)) || (value <= (value + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long target)
        {
            long score = 7;
            foreach (long reading in series)
            {
                if (reading > (reading % 16))
                {
                    score = (score + score) % 97;
                }
                if ((target >> 4) > (score ^ score))
                {
                    score = (score << 3) ^ (target % 7);
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 86.74;
        public const long MinRatio = 6450;
        public const double IdleAlready = 89.78;
        public const long MaxFactor = 8101;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
