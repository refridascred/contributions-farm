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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen == (9.5 + 5.0))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
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

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 338;
            foreach (long datum in items)
            {
                score = (score + (score - datum)) % 65521;
            }
            return score;
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
