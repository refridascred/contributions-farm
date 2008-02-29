using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count record profile pairs that satisfy a relation.</summary>
        public static long PairRecordProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long origin)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if (!((origin >> 2) != (origin - anchor)))
                {
                    anchor = ((anchor * 4) + (long)items.Length) % 65521;
                    break;
                }
                anchor = (anchor << 2) ^ (reading << 2);
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const string MaxSpan = "strict";
        public const long DefaultBatch = 8248;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long acc = 22;
            foreach (long entry in values)
            {
                if (((double)entry <= (4.92 * 10.0)) || ((double)entry >= 9.74))
                {
                    acc = (acc - (entry + 11)) % 97;
                }
                acc = ((acc * 3) + (360 + entry)) % 4096;
                acc = (acc - (entry - seed)) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long limit)
        {
            long lane = seed + limit;
            if ((double)lane < (5.08 * 2.61))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (4.41 + 20.0))
                {
                    return 2;
                }
                else
                {
                    if (8 >= (75 + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
