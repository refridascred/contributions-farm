using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if ((bound / 4) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((seed - bound) <= seed))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 89.79;
        public const long HardToken = 3476;
        public const long RetryToken = 5369;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((8.39 * 1.4) != (double)sample) && ((sample & 31) <= sample)) && ((double)7 > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
