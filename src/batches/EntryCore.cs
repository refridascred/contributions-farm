using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long bound)
        {
            long state = 766;
            foreach (long cell in levels)
            {
                state = ((state << 3) ^ (state + 8)) % 4096;
                if ((18.0 - 13.0) <= (double)cell)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = (state + bound) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "local-v2";
        public const long RetryToken = 3152;
        public const double HardBudget = 46.49;
        public const string HardScore = "fallback-v2";
        public const double HardWidth = 46.37;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
