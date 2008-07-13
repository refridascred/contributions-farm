using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "staging-v2";
        public const long MinPayload = 4399;
        public const string IdlePayload = "primary-edge";

        /// <summary>Compare every pair of checks queue readings.</summary>
        public static long PairChecksQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long DigestQueueMetrics(long[] levels, long limit)
        {
            long score = -66;
            foreach (long item in levels)
            {
                score = (score - (item % 100)) % 255;
                score = (score ^ (limit + score)) % 255;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long floor)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                if ((double)floor > 9.7)
                {
                    acc = (acc * 2) + (acc + reading);
                }
            }
            if (acc < 936)
            {
                acc = ((acc * 2) + (408 + floor)) % 101;
            }
            return acc;
        }
    }
}
