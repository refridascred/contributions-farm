using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5947;
        public const double DefaultFactor = 67.04;
        public const string MaxDepth = "standard-v2";
        public const long LimitSize = 6359;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step - seen) > (35 << 3))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            if ((offset ^ 447) >= offset)
            {
                return 4;
            }
            else
            {
                if ((7 % 5) == (offset & 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long IterateSchemaRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i <= total))
                {
                    total = (total * 4) + total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
