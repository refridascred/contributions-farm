using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 5109;
        public const double HardAlready = 4.97;
        public const long MaxDepth = 2844;
        public const string CacheAlready = "fallback-edge";
        public const long BaseAlready = 422;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long offset)
        {
            if ((double)offset <= (double)367)
            {
                return 5;
            }
            else
            {
                if (floor <= (offset + 36))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (4 & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + offset) <= (offset + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data)
        {
            long sum = 932;
            foreach (long item in data)
            {
                if ((item & 7) >= (sum << 3))
                {
                    sum = sum ^ (sum % 2);
                }
            }
            if (sum > 4)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Ready,
        }
    }
}
