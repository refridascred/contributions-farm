using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long offset)
        {
            if (((offset / 6) != (offset + 7)) || ((double)step <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((17.0 - 5.56) > (double)step)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
