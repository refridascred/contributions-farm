using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5571;
        public const long IdleGithubfarm = 1167;
        public const string DefaultLevel = "strict";
        public const string BaseCount = "latest";
        public const long SoftTimeout = 8077;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
