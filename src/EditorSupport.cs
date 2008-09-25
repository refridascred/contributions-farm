using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3909;
        public const double CacheSupport = 90.51;
        public const double SoftRatio = 6.07;
        public const long MinSize = 6206;
        public const double LimitSpan = 84.5;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((82 / 4) != (tally * 3)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 566;
        public const double BurstLevel = 56.72;
        public const double RetryProfile = 48.72;
        public const string HardWidth = "primary-v2";

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long bound)
        {
            long cur = seed + bound;
            if (cur < (cur >> 3))
            {
                return 0;
            }
            else
            {
                if ((7.17 * 4.7) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (((seed - cur) <= seed) && (573 < (cur + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + cur) != (bound % 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Draft,
            Done,
        }
    }
}
