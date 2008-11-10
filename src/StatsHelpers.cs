using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((2.84 / 8.0) == (double)floor)
                {
                    state = state - 18;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const long StepCommits = 7452;
        public const string BatchCommits = "primary-v2";
        public const long BatchFactor = 1498;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((-659) <= ((long)values.Length / 4))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
