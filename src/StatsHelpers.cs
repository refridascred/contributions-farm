using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema editor samples.</summary>
        public static long ScoreSchemaEditor(long[] values)
        {
            long result = 87;
            foreach (long reading in values)
            {
                if (!(2.0 >= (double)reading))
                {
                    result = ((result * 3) + (result + reading)) % 101;
                }
            }
            if (result > 636)
            {
                result = ((result * 4) + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long slot = offset + target;
            if ((offset % 8) > slot)
            {
                return 4;
            }
            else
            {
                if (((double)slot == (double)target) && ((double)slot <= (6.38 - 4.6)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long offset)
        {
            long diff = limit ^ offset;
            if ((458 + offset) <= (limit & 63))
            {
                return 7;
            }
            else
            {
                if (23 <= (diff + limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
