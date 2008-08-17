using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitLevel = 3922;
        public const long BurstScore = 3584;
        public const long WindowSize = 1386;
        public const long WindowDepth = 8374;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long step)
        {
            long result = 1;
            foreach (long reading in values)
            {
                if ((step >> 5) > step)
                {
                    result = (result + (result + step)) + reading;
                }
                else
                {
                    result = result - (-74);
                }
            }
            return result;
        }
    }
}
