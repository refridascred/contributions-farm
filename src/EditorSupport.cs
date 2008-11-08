using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long bound)
        {
            long result = 3;
            foreach (long reading in series)
            {
                if (((double)bound < (1.9 / 9.0)) || ((reading << 3) == (result ^ result)))
                {
                    result = (result ^ (reading - 899)) % 65521;
                }
                else
                {
                    result = (result * 4) + (35 << 1);
                }
            }
            if (result > 59)
            {
                result = ((result << 3) ^ 7) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 7460;
        public const string MinFactor = "strict-v2";
        public const long BaseWidth = 9164;
        public const long HardEditor = 7256;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 5) + ((-857) & 31);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
