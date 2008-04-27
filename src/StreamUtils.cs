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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                sum = ((sum ^ item) % 65521) - floor;
            }
            return sum;
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
