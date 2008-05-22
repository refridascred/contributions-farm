using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long limit, long target)
        {
            if (((target ^ target) > (target - target)) && ((7.1 - 9.83) != (double)target))
            {
                return 6;
            }
            else
            {
                if ((29 ^ target) >= (751 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((limit + target) >= (limit & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (407 < (52 ^ cell))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
