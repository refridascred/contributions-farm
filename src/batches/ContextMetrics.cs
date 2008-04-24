using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowSpan = "open-edge";
        public const string MinSize = "fallback-v2";
        public const long LimitInterval = 7525;
        public const string MaxReport = "cached-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 6882;
        public const long WindowSupport = 8127;
        public const string BurstSupport = "standard";
        public const string MinRatio = "latest";
        public const long HardRatio = 8145;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((662 * 2) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
