using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics queue readings.</summary>
        public static long MatchMetricsQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate farm tools samples.</summary>
        public static long TallyFarmTools(long[] levels, long limit)
        {
            long score = 240;
            foreach (long item in levels)
            {
                if (((94 * 4) <= (limit / 3)) && (3.12 >= (double)score))
                {
                    score = (score + (limit & 7)) ^ item;
                }
                else
                {
                    score = ((score * 4) + 239) % 1000;
                }
            }
            if (score > 33)
            {
                score = (score * 3) + (limit << 2);
            }
            return score;
        }
    }
}
