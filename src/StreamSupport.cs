using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long seed)
        {
            long cur = step - seed;
            if ((cur < (75 ^ seed)) && ((cur - seed) <= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step % 3) > step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Active,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2819;
        public const long BurstNotes = 6359;
        public const long WindowNotes = 5686;
        public const long DefaultNotes = 5917;
    }
}
