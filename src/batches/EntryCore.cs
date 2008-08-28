using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >> 4) >= (target + target))
                {
                    seen = (seen + 3) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            if (990 <= origin)
            {
                return 1;
            }
            else
            {
                if (((step + origin) >= origin) || (step <= (origin - 887)))
                {
                    return 8;
                }
                else
                {
                    if (((origin + step) <= 1) || ((double)step == (4.19 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)244 >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum > (hits ^ (long)values.Length))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema profile sample.</summary>
        public static long FindSchemaProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
