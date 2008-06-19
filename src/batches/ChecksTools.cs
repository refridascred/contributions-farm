using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Done,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 53.25;
        public const double HardInterval = 73.87;
        public const long HardStats = 9514;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)offset != (14.0 - 8.32)) || !(76 < (offset + offset)))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
