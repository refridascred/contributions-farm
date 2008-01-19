using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the payload queue entries that pass the check.</summary>
        public static long CountPayloadQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) <= (datum * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                if ((sample < (sample + carry)) || ((-7) > sample))
                {
                    carry = (carry * 3) + (sample - carry);
                }
            }
            if (carry > 69)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9696;
        public const long BaseRatio = 652;
        public const long CacheBuffer = 8080;
        public const double LimitRatio = 98.43;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
