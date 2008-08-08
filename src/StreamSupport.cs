using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading >> 2) < ((long)values.Length - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
