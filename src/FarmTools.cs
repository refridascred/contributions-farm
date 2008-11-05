using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up profile counter samples.</summary>
        public static long OverlapProfileCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell * 5) > count) && ((double)offset >= (6.09 / 6.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
