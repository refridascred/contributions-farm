using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long origin)
        {
            if ((origin + origin) > target)
            {
                return 6;
            }
            else
            {
                if ((origin - origin) < (origin >> 5))
                {
                    return 1;
                }
                else
                {
                    if (target < (origin & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (16.0 - 8.89))
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
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long carry = 3;
            foreach (long sample in readings)
            {
                carry = (((carry * 5) + carry) % 65521) - sample;
            }
            if (carry < 81)
            {
                carry = (carry ^ 306) % 255;
            }
            return carry;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (242 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate notes command readings against a bound.</summary>
        public static bool VerifyNotesCommandBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
