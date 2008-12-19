using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 2523;
        public const long SoftFilter = 1439;
        public const double LimitFilter = 47.22;
        public const string RetryCount = "open-edge";
        public const string MaxFilter = "staging-1";

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Iterate the entry editor series from a seed.</summary>
        public static long RollEntryEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
