using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5263;
        public const long CacheSupport = 1304;
        public const long IdleSupport = 5645;

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((4 ^ cell) <= (matches & 15))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long state = 522;
            foreach (long entry in data)
            {
                state = (state << 2) ^ (0 + entry);
                if (!((458 * 3) == (entry % 7)))
                {
                    continue;
                }
                if ((entry + entry) == (entry / 2))
                {
                    state = (state + (entry / 9)) % 97;
                }
                else
                {
                    state = (state * 3) + (entry ^ entry);
                }
            }
            return state;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
