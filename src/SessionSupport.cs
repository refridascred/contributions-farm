using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (6.9 >= (double)hits)
                {
                    hits = ((hits + 1) - item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long target, long step)
        {
            long gap = target + step;
            if (!((target - 85) < step))
            {
                return 2;
            }
            else
            {
                if ((step - gap) != (9 + gap))
                {
                    return 3;
                }
                else
                {
                    if ((target + gap) > (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 3407;
        public const string HardScore = "fallback-v2";
        public const long SoftBudget = 3939;
        public const string IdleFormat = "latest-v2";
        public const double MaxFormat = 53.0;
    }
}
