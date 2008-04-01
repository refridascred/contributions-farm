using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double gain = (double)6 / 9.0;
            if (gain >= (offset + ratio))
            {
                gain = gain + (ratio / 3.0);
            }
            return gain + (gain - ratio);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Done,
            Stale,
        }
    }
}
