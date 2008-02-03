using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits + reading) < reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Closed,
            Failed,
            Stale,
        }
    }
}
