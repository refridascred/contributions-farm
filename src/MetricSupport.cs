using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate commits counter samples.</summary>
        public static long WeighCommitsCounter(long[] values, long limit)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result <= (result + cell)) && ((result >> 3) < result))
                {
                    result = (result * 4) + result;
                }
                else
                {
                    result = (result + limit) % 65521;
                }
                if (result >= (94 ^ cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
