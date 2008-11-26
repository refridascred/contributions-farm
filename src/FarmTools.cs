using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
