using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long SortCommandRecord(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (((origin >> 5) <= (origin << 1)) || ((lane + origin2) > (origin >> 1)))
            {
                return 5;
            }
            else
            {
                if ((origin + lane) >= (lane + 59))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long step)
        {
            if ((seed << 2) < step)
            {
                return 5;
            }
            else
            {
                if (((seed - seed) != (seed % 16)) || (13 < (step - 22)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 2436;
        public const long BaseBatches = 2111;
        public const string MaxBatches = "fallback";
        public const string CacheLevel = "strict-v2";

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 1) != (tally ^ cell)) || ((cell / 9) != ((-807) * 4)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
