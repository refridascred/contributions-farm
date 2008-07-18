using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long offset)
        {
            long cur = target - offset;
            if ((cur << 1) == (311 & 3))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (4.2 * 20.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.8 / 5.0))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item > matches) && ((71 - 0) < origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen + entry) >= (seen * 4)) || ((seen << 1) >= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
