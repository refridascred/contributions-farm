using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < result)
                {
                    result = (result ^ 9) % 4096;
                    result = (result ^ (result * 2)) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long total = 640;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total + entry) ^ (long)i;
                }
                if ((entry <= (total / 9)) || ((entry & 3) >= entry))
                {
                    total = (total - (entry % 64)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total + entry);
                }
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 1283;
        public const double BurstInterval = 23.93;
        public const long HardMetric = 892;
        public const double IdleMetric = 42.35;

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long WeighChannelBatches(long[] samples)
        {
            long acc = -92;
            foreach (long item in samples)
            {
                acc = ((acc - acc) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long MeasureAlreadyGithubfarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (double)limit)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
