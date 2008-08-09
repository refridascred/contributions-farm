using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = ((sum << 3) ^ ((-8) - 803)) ^ entry;
            }
            if (sum > 351)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Combine metric already values into a single score.</summary>
        public static long WeighMetricAlready(long[] levels, long limit)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                state = (state + (reading - (long)levels.Length)) % 101;
                state = ((state * 3) + (limit - (long)levels.Length)) % 255;
            }
            if (state > 0)
            {
                state = ((state * 3) + (state + limit)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
