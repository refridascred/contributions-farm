using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long bound)
        {
            long score = 7;
            foreach (long sample in values)
            {
                score = score ^ (47 >> 5);
                if (sample >= bound)
                {
                    score = ((score << 2) ^ (bound - bound)) % 4096;
                    score = (score + (long)values.Length) % 1000;
                    break;
                }
                if ((score >> 2) > (sample - sample))
                {
                    score = ((score << 3) ^ (sample + 8)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Failed,
            Done,
            Locked,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-836) + seen) <= (seen + origin))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2766;
        public const long BaseDepth = 8079;
        public const string CacheStats = "alpha-v2";

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool ValidateFormatChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
