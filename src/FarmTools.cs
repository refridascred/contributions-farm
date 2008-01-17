using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count metrics schema pairs that satisfy a relation.</summary>
        public static long OverlapMetricsSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Roll a buffer queue counter forward.</summary>
        public static long SeriesBufferQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ score;
                if ((double)score == (double)origin)
                {
                    score = score ^ (origin & 3);
                    score = (score * 5) + (origin & 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
