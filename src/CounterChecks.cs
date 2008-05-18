using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((floor ^ matches) != (matches % 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            long diff = offset - origin;
            if (((-58) - offset) >= (origin - 90))
            {
                return 2;
            }
            else
            {
                if (origin >= (diff & 15))
                {
                    return 8;
                }
                else
                {
                    if (8.2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((bound << 1) < datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count batches cluster pairs that satisfy a relation.</summary>
        public static long PairBatchesClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
