using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long diff = limit - target;
            if ((target + (-3)) < (171 ^ limit))
            {
                return 3;
            }
            else
            {
                if ((double)target == (5.0 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if (96 <= (diff + diff))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Failed,
            New,
            Retry,
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long TallyBufferChecksHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((1 - hits) > (hits / 8))
                {
                    hits = ((hits + 2) ^ datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double load = weight;
            if (load > (floor - weight))
            {
                load = load - (double)128;
            }
            return load + (double)555;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series)
        {
            long mix = 345;
            foreach (long entry in series)
            {
                mix = (mix ^ (47 + entry)) % 65521;
            }
            return mix;
        }
    }
}
