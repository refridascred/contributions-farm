using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count metrics githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapMetricsGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout record readings against a bound.</summary>
        public static bool CheckLayoutRecordRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
