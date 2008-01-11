using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + limit) > (reading / 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 4332;
        public const long IdleBudget = 669;
        public const long HardCount = 4660;
        public const long SoftDepth = 192;
        public const string BurstContributi = "latest-1";

        /// <summary>Classify a command cache pair into a bucket.</summary>
        public static long GradeCommandCache(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane << 1) < lane)
            {
                return 6;
            }
            else
            {
                if (!(step < (step / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((bound < (step - 105)) && ((lane + step) > 28))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
