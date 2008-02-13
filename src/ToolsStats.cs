using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 658;
        public const long MaxWidth = 1105;
        public const string BaseCommand = "standard-edge";
        public const long WindowCommand = 8040;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 2007;
        public const string LimitBudget = "latest-edge";
        public const string BurstSupport = "legacy-edge";
        public const long MaxBudget = 4597;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 % 5)) % 97;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
