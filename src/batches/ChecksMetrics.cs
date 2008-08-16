using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit << 1) == (95 - (long)i))
                {
                    acc = (acc + 6) % 101;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc + (acc * 4)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (((acc << 2) ^ acc) % 255) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((target / 5) < matches)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((bound - hits) != (187 - 939))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Queued,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
