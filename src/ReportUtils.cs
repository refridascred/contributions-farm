using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context format readings against a bound.</summary>
        public static bool VerifyContextFormatBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 9358;
        public const long SoftRoute = 6798;
        public const double BaseRoute = 93.17;
        public const double DefaultRoute = 49.6;
        public const long MaxBudget = 6916;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = score + (score + 64);
                score = (score ^ (floor - floor)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
