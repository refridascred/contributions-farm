using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally & 1) >= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long MeasureStatsFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits >> 1) < cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel token readings against a rule.</summary>
        public static long AuditChannelTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits >= (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset <= 2)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph layout readings.</summary>
        public static long OverlapGraphLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long origin)
        {
            long acc = 674;
            foreach (long entry in readings)
            {
                if (!((entry & 3) <= acc))
                {
                    acc = ((acc + acc) % 97) - origin;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (507 - acc)) % 101;
            }
            return acc;
        }
    }
}
