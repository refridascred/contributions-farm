using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long acc = 585;
            foreach (long cell in samples)
            {
                if ((cell >> 5) <= acc)
                {
                    acc = ((acc * 3) + (cell ^ 332)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 7134;
        public const double IdleScore = 71.64;
        public const long WindowFormat = 1908;
        public const string BatchScore = "strict-edge";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long step)
        {
            if ((double)step > (9.0 - 11.0))
            {
                return 5;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
