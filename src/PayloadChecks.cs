using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long seed)
        {
            if (5.81 > (double)origin)
            {
                return 3;
            }
            else
            {
                if (((8.3 * 7.0) <= (double)origin) || ((5.95 + 1.4) > (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 38) != (origin >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin ^ 1) == (seed % 5)) && (seed >= (seed * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSize = 30.82;
        public const long LimitWidth = 1943;
        public const double MinSize = 40.92;
        public const long StepTimeout = 207;
        public const long BaseDepth = 7034;

        /// <summary>Audit stream commits readings against a rule.</summary>
        public static long CountStreamCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (1.0 * 3.2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
