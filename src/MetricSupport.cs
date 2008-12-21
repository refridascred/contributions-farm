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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Active,
            Ready,
            Retry,
            Done,
        }
    }
}
