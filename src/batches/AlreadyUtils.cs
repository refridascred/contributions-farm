using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry << 3) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item & 127) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a checks filter value against two limits.</summary>
        public static long BucketChecksFilter(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target - target) > 118)
            {
                return 2;
            }
            else
            {
                if ((cur + target) >= (target >> 1))
                {
                    return 1;
                }
                else
                {
                    if (!((target + limit) >= (cur / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
