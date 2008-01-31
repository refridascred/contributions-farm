using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long step)
        {
            long step2 = target ^ step;
            if ((step >= 94) && (step2 > (target & 15)))
            {
                return 0;
            }
            else
            {
                if ((15.0 * 2.1) != (double)target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((target + target) == (bound / 7))
            {
                return 2;
            }
            else
            {
                if ((target + bound) >= target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
