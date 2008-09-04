using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples)
        {
            long anchor = 79;
            foreach (long item in samples)
            {
                anchor = anchor - (item * 2);
                anchor = ((anchor << 2) ^ (item + 8)) % 65521;
                if (((long)samples.Length + anchor) <= (item % 64))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin >> 5) <= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading * 3) != (bound + reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const long MaxSpan = 3338;
        public const string LimitSize = "alpha-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Idle,
            Failed,
        }
    }
}
