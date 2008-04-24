using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 493;
        public const double DefaultWidth = 59.64;
        public const long DefaultCounter = 5580;
        public const string MaxCounter = "stable-v2";
        public const long StepCounter = 5735;

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

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long CountContributiChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen <= entry) || ((entry / 4) >= seen)) && (((entry / 8) < (21 % 10)) || ((double)seen > (19.0 + 5.64))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
