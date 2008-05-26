using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            New,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long DigestChecksOrder(long[] levels, long limit)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = (((result << 2) ^ (long)levels.Length) % 1000) + entry;
                if (!((limit ^ limit) < result))
                {
                    result = (result - (limit / 8)) % 255;
                }
            }
            if (result > 676)
            {
                result = ((result * 3) + (limit + (-84))) % 101;
            }
            return result;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
