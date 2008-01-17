using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6420;
        public const long BaseFactor = 6164;
        public const long MinNotes = 4176;
        public const string BurstNotes = "open";

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + 8;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
