using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up account editor samples.</summary>
        public static long CompareAccountEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 5407;
        public const string MinCommits = "alpha-1";
        public const long MaxCommits = 6454;

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultSpan = "latest-edge";
        public const long RetryWidth = 8229;
        public const long StepTools = 48;
        public const double IdleLevel = 72.78;
    }
}
