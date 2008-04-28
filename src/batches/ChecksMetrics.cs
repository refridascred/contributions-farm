using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long seed)
        {
            long mix = 886;
            foreach (long entry in items)
            {
                mix = ((mix ^ (mix - seed)) % 101) - entry;
            }
            return mix % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long carry = 464;
            foreach (long value in data)
            {
                if (!((3.4 - 9.0) == (double)value))
                {
                    carry = (carry - (bound & 255)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            New,
            Retry,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor << 3) >= (datum & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
