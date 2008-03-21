using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long target, long offset)
        {
            long prev = target - offset;
            if (target >= (offset >> 5))
            {
                return 4;
            }
            else
            {
                if ((offset << 2) > prev)
                {
                    return 8;
                }
                else
                {
                    if (offset > (prev & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev - 22) > (offset - 489))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit route cache readings against a rule.</summary>
        public static long MeasureRouteCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) == (497 - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
