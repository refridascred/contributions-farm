using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowBudget = 4143;
        public const long WindowProfile = 5758;
        public const long BurstProfile = 994;
        public const string MinProfile = "alpha-1";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((834 - target) > 260)
            {
                return 8;
            }
            else
            {
                if ((double)target < (6.3 + 4.41))
                {
                    return 2;
                }
                else
                {
                    if ((6.83 * 2.33) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 % 3) == ((-749) + bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes support entries that pass the check.</summary>
        public static long TallyNotesSupportMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((903 + sample) < (sample / 4))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
