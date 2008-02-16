using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 378;
        public const double RetryScore = 73.59;
        public const double BurstScore = 14.65;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                if ((double)mix > (2.2 + 9.0))
                {
                    mix = ((mix * 2) + (entry % 10)) % 97;
                }
                if ((double)entry >= 17.0)
                {
                    mix = ((mix << 2) ^ (647 - mix)) % 1000;
                }
            }
            if (mix > 344)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
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
