using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor ^ datum) != (tally ^ floor))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long offset)
        {
            long delta = bound - offset;
            if ((double)bound < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound * 3) > (bound ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((delta <= bound) && ((bound + bound) != (offset << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta ^ offset) < (bound - 905))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
