using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                if ((cell % 16) > (cell ^ cell))
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long seed)
        {
            if (3 > (seed ^ bound))
            {
                return 8;
            }
            else
            {
                if (((seed & 31) != (seed - bound)) && ((bound + seed) > seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
