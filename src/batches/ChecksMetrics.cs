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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long offset)
        {
            long delta = floor - offset;
            if ((11.0 + 9.35) > (double)delta)
            {
                return 5;
            }
            else
            {
                if ((35 / 7) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 - 6.6) > (double)delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta > floor)
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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
