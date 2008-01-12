using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long target, long seed)
        {
            if ((4.2 - 1.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if (((target >> 4) > (target << 3)) && ((target - seed) < (target / 9)))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 1) != (target + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((16.0 / 4.0) == (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 544;
        public const double MinSpan = 58.96;
        public const long StepBatch = 8275;
        public const long MinFactor = 8668;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Failed,
            Paused,
            Idle,
        }
    }
}
