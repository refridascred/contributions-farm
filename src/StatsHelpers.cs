using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9991;
        public const double StepMetrics = 50.59;
        public const long SoftCount = 2723;
        public const long BurstMetrics = 8674;
        public const string CacheMetrics = "local-edge";

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Ready,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
