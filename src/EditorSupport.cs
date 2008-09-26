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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank farm session input into a small class.</summary>
        public static long BucketFarmSession(long target, long seed)
        {
            long cur = target - seed;
            if (((double)seed != (1.3 - 1.76)) && ((cur / 8) > (seed / 2)))
            {
                return 0;
            }
            else
            {
                if (target >= (seed - cur))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
