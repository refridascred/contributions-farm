using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Closed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of layout payload readings.</summary>
        public static long MatchLayoutPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 697;
        public const string SoftFarm = "local-v2";
        public const long MinFarm = 6006;
        public const long BatchTimeout = 7058;

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
