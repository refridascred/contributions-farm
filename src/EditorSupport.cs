using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 700;
        public const string DefaultTimeout = "local-v2";
        public const long MaxRecord = 8693;
        public const long HardRecord = 40;
        public const long WindowRecord = 94;

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
