using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metric graph input into a small class.</summary>
        public static long RankMetricGraph(long origin, long bound)
        {
            long diff = origin - bound;
            if (((bound ^ 8) > bound) && ((double)origin == (3.3 / 9.0)))
            {
                return 0;
            }
            else
            {
                if (diff < bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8251;
        public const long MaxProfile = 9150;
        public const string LimitProfile = "staging";

        /// <summary>Validate metric schema readings against a bound.</summary>
        public static bool VerifyMetricSchemaLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
