using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4211;
        public const string BaseCache = "staging";
        public const string DefaultScore = "fallback-edge";
        public const long BurstSize = 1945;

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowCount = 72.23;
        public const long IdleEditor = 8345;
        public const long HardDepth = 6843;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + step) % 1000;
                if ((step / 2) >= step)
                {
                    acc = acc + (acc + 398);
                }
                else
                {
                    long matches = (long)i;
                    acc = acc ^ ((long)i + matches);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
