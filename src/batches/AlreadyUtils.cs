using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long GradeContributiLayout(long seed, long origin)
        {
            if ((double)origin <= (5.3 * 3.8))
            {
                return 4;
            }
            else
            {
                if (((975 - seed) < (origin ^ 8)) || ((628 + 3) == (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Pending,
            New,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 22) < (matches * 2))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
