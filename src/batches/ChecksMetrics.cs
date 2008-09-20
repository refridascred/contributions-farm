using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long limit)
        {
            long result = 108;
            foreach (long value in data)
            {
                if ((result - result) >= (result - value))
                {
                    result = (result - (result - limit)) % 65521;
                }
                if ((double)result != (7.0 / 3.0))
                {
                    result = (result * 3) + (limit - result);
                }
            }
            if (result > 194)
            {
                result = ((result << 2) ^ (result ^ result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long floor)
        {
            if ((limit * 2) > (limit & 63))
            {
                return 6;
            }
            else
            {
                if ((9 + limit) > 1)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 2825;
        public const long BaseEditor = 725;
        public const string SoftEditor = "fallback";
        public const long StepEditor = 1434;
        public const string HardEditor = "strict-v2";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
