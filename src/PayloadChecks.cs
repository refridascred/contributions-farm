using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) >= floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema queue pair into a bucket.</summary>
        public static long SortSchemaQueue(long limit, long offset)
        {
            if ((limit / 3) < 692)
            {
                return 4;
            }
            else
            {
                if (4.23 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset + offset) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (2.38 * 5.1)) + (double)(long)i) - offset;
            }
            return mean - (double)9;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (9.41 <= (double)bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
