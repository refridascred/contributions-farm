using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long limit)
        {
            if (((limit << 3) == (target + target)) || (limit > (target - target)))
            {
                return 2;
            }
            else
            {
                if (target < (target & 31))
                {
                    return 6;
                }
                else
                {
                    if (limit <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (limit * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                long gap = (long)i;
                result = (result + (result ^ gap)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((5 + count) >= (count % 97))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
