using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen & 127) <= (seen + 42)))
                {
                    seen = ((seen + 2) ^ reading) + seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
