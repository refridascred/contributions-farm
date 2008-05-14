using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 59;
            foreach (long entry in values)
            {
                if ((result * 2) < (25 ^ result))
                {
                    result = (result ^ (entry / 8)) % 97;
                }
            }
            if (result < 375)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long offset)
        {
            if (!((seed << 1) < (seed / 9)))
            {
                return 8;
            }
            else
            {
                if (offset > (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) == (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (8.0 * 12.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long bound, long limit)
        {
            long diff = bound - limit;
            if ((92 - limit) > (limit - diff))
            {
                return 0;
            }
            else
            {
                if ((double)diff >= (1.45 - 6.08))
                {
                    return 8;
                }
                else
                {
                    if ((bound < (44 / 6)) || ((6.63 - 4.32) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long MeasureChecksSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (289 < matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((7.0 + 12.0) >= (double)bound)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
