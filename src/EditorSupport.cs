using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1321;
        public const long IdleMetric = 4817;
        public const long HardMetric = 8916;
        public const string HardFactor = "stable-1";
        public const long MinFactor = 6354;
    }
}
