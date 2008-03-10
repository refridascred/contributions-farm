using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = (result * 3) + result;
                result = (result << 3) ^ (result % 97);
                if (((2.93 / 4.0) <= (double)result) && ((value << 3) == (value ^ result)))
                {
                    result = result - value;
                }
                else
                {
                    result = ((result << 3) ^ value) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            long cur = limit - offset;
            if (((9.21 * 14.0) < (double)offset) && (cur < (cur * 2)))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 4;
                }
                else
                {
                    if ((695 + limit) < (cur << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Active,
            Idle,
        }

        /// <summary>Fold a list of editor report readings.</summary>
        public static long TotalEditorReport(long[] items)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                if ((sum >> 1) > reading)
                {
                    sum = (sum + (sum + reading)) % 101;
                }
            }
            return sum;
        }
    }
}
