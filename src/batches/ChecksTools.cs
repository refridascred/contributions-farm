using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long TotalEditorMetrics(long[] series, long seed)
        {
            long sum = 56;
            foreach (long sample in series)
            {
                if (!((double)sample < (double)320))
                {
                    sum = ((sum + (sum ^ sample)) % 1000) - seed;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6717;
        public const double StepFactor = 43.1;
        public const double BatchDepth = 98.84;
        public const long WindowSize = 732;
        public const long LimitChannel = 9188;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
