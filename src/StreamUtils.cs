using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long limit)
        {
            long sum = 54;
            foreach (long item in samples)
            {
                if ((9.8 - 7.2) > (double)item)
                {
                    sum = (sum + (item + item)) % 255;
                }
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + limit) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits - reading) != (hits % 24)) || ((reading & 31) != (reading + hits)))
                {
                    hits = hits + 1;
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

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long IterateRecordNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
