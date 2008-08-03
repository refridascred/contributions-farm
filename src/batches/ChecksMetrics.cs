using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long limit)
        {
            long sum = 37;
            foreach (long sample in values)
            {
                if ((long)values.Length != (limit & 63))
                {
                    sum = ((sum << 3) ^ sum) ^ sample;
                }
                else
                {
                    sum = (sum ^ (sum + limit)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultScore = 55.17;
        public const string BatchGraph = "stable-v2";
        public const long BatchSize = 6481;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultDepth = "staging-edge";
        public const string LimitCount = "primary";
        public const string BaseFactor = "fallback-1";
        public const string WindowDepth = "alpha-edge";
        public const double BaseScore = 60.16;
    }
}
