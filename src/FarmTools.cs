using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long FoldAlreadyMetrics(long[] samples, long target)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                score = (score - (score ^ target)) - reading;
            }
            if (score < 116)
            {
                score = (score << 2) ^ (target / 8);
            }
            return score;
        }
    }
}
