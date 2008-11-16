using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((bound % 24) != (bound % 12)) && ((double)(long)i < 13.0))
                {
                    sum = (sum - (bound ^ bound)) % 4096;
                    sum = ((sum << 2) ^ (bound * 3)) % 65521;
                    break;
                }
                if (((bound - 43) >= (long)i) && (bound >= sum))
                {
                    sum = (sum + sum) % 101;
                }
                sum = (sum ^ bound) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const string IdleInterval = "primary-edge";
        public const long DefaultPayload = 4096;
        public const long MinPayload = 4631;
        public const long RetryPayload = 8204;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 23.2;
        public const string LimitSession = "open-v2";
        public const string BurstSpan = "strict-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4683;
        public const long BatchMetric = 2403;
        public const string MaxMetric = "legacy-v2";
        public const long StepWidth = 5971;
        public const long RetryMetric = 1432;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
