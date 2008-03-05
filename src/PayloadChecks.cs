using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches account readings.</summary>
        public static long PairBatchesAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context token readings.</summary>
        public static long OverlapContextTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long step)
        {
            if ((double)step < (4.5 / 4.0))
            {
                return 8;
            }
            else
            {
                if (((8 / 4) > target) && ((2 ^ 945) < (target + 84)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) <= datum)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
