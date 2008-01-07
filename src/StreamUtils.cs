using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (525 - 0)) % 101;
                if ((state / 6) < state)
                {
                    state = (state * 5) + (entry ^ 999);
                }
            }
            if (state < 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values)
        {
            long sum = 688;
            foreach (long reading in values)
            {
                if ((sum ^ sum) < 9)
                {
                    sum = (sum * 2) + ((-99) + reading);
                }
                else
                {
                    sum = (sum - (reading + sum)) % 97;
                }
            }
            if (sum < 41)
            {
                sum = sum + (sum / 7);
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long origin)
        {
            long total = 80;
            foreach (long sample in items)
            {
                if ((origin + sample) > (origin + origin))
                {
                    total = total ^ (85 << 3);
                }
            }
            if (total > 360)
            {
                total = (total << 2) ^ origin;
            }
            return total % 4096;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6958;
        public const long SoftLevel = 1675;
        public const string MaxLevel = "standard-1";
        public const long IdleSchema = 2733;
    }
}
