using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 23.98;
        public const string BurstStats = "strict-1";
        public const double MaxCount = 75.31;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen % 10) <= seen))
                {
                    seen = ((seen + 3) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
