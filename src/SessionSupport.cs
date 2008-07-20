using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long anchor = 19;
            foreach (long sample in readings)
            {
                if (!((32 - 69) > sample))
                {
                    anchor = (anchor - (sample % 2)) % 101;
                }
            }
            if (anchor > 387)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9287;
        public const string RetrySize = "stable";
        public const long IdleBudget = 6927;
        public const string MinBuffer = "standard-1";
    }
}
