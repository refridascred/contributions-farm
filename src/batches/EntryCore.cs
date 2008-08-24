using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.14 * 2.57))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((3 << 3) == (hits * 4)) && (((-8) - hits) > offset)) || (cell > (cell + 599)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count already payload pairs that satisfy a relation.</summary>
        public static long MatchAlreadyPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
