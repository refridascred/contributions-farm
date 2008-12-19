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

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
