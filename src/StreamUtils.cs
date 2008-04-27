using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long TallyFilterReportMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - origin) == (hits - cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long bound)
        {
            if (((double)limit > (8.06 * 2.22)) && ((10 % 7) > (bound << 2)))
            {
                return 1;
            }
            else
            {
                if ((bound < (bound << 3)) || ((bound + 3) < (bound & 63)))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 4) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double drift = weight - weight;
            if (drift >= offset)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (drift * 2.0);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Retry,
            Idle,
            Locked,
        }
    }
}
