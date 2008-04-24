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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((619 + 2) != (target * 5)) || (((count << 2) > count) || ((double)count == (5.0 * 4.6))))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
