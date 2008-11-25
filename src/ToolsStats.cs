using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = result - ((long)i - origin);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((long)series.Length ^ acc) >= 279)
                {
                    acc = acc + (value + acc);
                }
            }
            if (acc > 181)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long MatchMetricBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer report entries that pass the check.</summary>
        public static long TallyBufferReportHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading >> 2) != (989 * 3)) && ((9.0 - 4.19) >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
