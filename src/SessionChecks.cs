using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools account readings against a rule.</summary>
        public static long TallyToolsAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(((double)cell != (double)offset) && ((offset / 2) >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4166;
        public const string MinInterval = "alpha-edge";
        public const double WindowLayout = 49.62;
        public const long BaseScore = 4229;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 734;
        public const string CacheToken = "open-v2";
        public const long MinRatio = 3300;
    }
}
