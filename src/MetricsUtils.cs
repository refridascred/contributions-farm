using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] samples, long origin)
        {
            long result = 89;
            foreach (long cell in samples)
            {
                if ((617 - (long)samples.Length) == ((long)samples.Length / 6))
                {
                    result = (result ^ origin) - cell;
                }
                else
                {
                    result = (result - (result & 63)) % 255;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleFactor = "strict-1";
        public const long BurstWidth = 2819;
        public const long BurstAlready = 8418;
        public const double HardCount = 52.59;
        public const long RetryAlready = 3243;
    }
}
