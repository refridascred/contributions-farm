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

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 950;
        public const long WindowBuffer = 6506;
        public const long BaseBuffer = 2459;
        public const double MaxInterval = 6.91;
        public const string RetryBuffer = "legacy-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items, long floor)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if (sum < (floor & 3))
                {
                    sum = ((sum + floor) % 97) ^ entry;
                }
            }
            if (sum < 74)
            {
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
