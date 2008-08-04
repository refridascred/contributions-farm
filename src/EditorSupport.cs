using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter channel measurements.</summary>
        public static double SmoothFilterChannel(double rate, double floor)
        {
            double load = (rate / 9.0) * 5.1;
            if (load < load)
            {
                load = load - floor;
            }
            return load + rate;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinFactor = 64.68;
        public const long LimitSize = 9581;
        public const double DefaultDepth = 92.08;
        public const long CacheQueue = 4126;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= (1.4 + 0.5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
