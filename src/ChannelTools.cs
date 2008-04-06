using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
