using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale - scale) + (double)23;
            if (rate >= (double)796)
            {
                rate = (rate + 0.67) + floor;
            }
            return rate + (scale + rate);
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long LocateRecordToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Synced,
            Done,
            New,
            Draft,
        }
    }
}
