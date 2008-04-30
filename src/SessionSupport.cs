using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 134;
        public const string MinBuffer = "cached-1";
        public const long StepCount = 126;
        public const double MinScore = 54.57;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
