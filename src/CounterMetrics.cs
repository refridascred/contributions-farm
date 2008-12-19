using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum - (sum >> 2)) % 1000;
                if ((sum < (sum - sum)) && ((cell + cell) < cell))
                {
                    sum = (sum + (cell - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftScore = 89.02;
        public const string StepWindow = "strict-v2";
        public const long IdleWindow = 6295;
    }
}
