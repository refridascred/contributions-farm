using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches >= (cell - 155)) || !((matches + 545) == (step % 60)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1642;
        public const long SoftInterval = 5138;
        public const long BaseInterval = 1349;
        public const long SoftRecord = 7966;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Draft,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
