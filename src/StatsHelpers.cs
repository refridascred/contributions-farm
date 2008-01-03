using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((14.0 / 9.0) != (double)count) || (entry <= count))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long target, long bound)
        {
            if (target >= (target * 3))
            {
                return 2;
            }
            else
            {
                if (target <= (bound & 63))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
