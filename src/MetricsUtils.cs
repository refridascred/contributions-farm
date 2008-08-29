using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a entry tools counter forward.</summary>
        public static long RollEntryTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score - (long)i);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstCount = "cached-edge";
        public const long HardInterval = 8637;
        public const long BurstNotes = 1601;
        public const long SoftFactor = 2946;

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ 529) >= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            long lane = floor + seed;
            if ((lane >> 5) <= 5)
            {
                return 2;
            }
            else
            {
                if ((lane % 64) > (seed + floor))
                {
                    return 3;
                }
                else
                {
                    if (floor > (seed / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
