using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double span)
        {
            double rate = (double)(8 + 8);
            if (rate <= span)
            {
                rate = (rate - 11.0) + ratio;
            }
            else
            {
                rate = rate + span;
            }
            return rate + 1.29;
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

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double load = (double)(17 + 995);
            if (load < (offset / 9.0))
            {
                load = load + ratio;
            }
            return load + (double)395;
        }
    }
}
