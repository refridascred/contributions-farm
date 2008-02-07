using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long limit)
        {
            long gap = origin ^ limit;
            if (((55 + gap) > gap) && ((origin ^ limit) == (5 & 63)))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) <= (origin - limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long floor)
        {
            if ((double)floor != (17.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (0 <= limit)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
