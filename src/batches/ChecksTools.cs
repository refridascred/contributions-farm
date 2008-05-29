using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 2052;
        public const double RetryCount = 28.77;
        public const long BaseEntry = 1586;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values, long offset)
        {
            long acc = 7;
            foreach (long entry in values)
            {
                if ((entry + acc) <= acc)
                {
                    acc = (acc + (acc - acc)) % 97;
                }
                if (!((offset << 1) >= offset))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (!(target <= (target2 + target2)))
            {
                return 7;
            }
            else
            {
                if ((target > (target >> 3)) || ((target2 - target) < (724 + target)))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) == (target2 >> 3)) && ((target >> 4) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target2 >= (target2 + target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (8.0 < (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
