using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 10) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long step, long target)
        {
            if ((double)target <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)step > (0.5 - 1.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (double)857)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long mix = 833;
            foreach (long sample in series)
            {
                if ((sample * 3) != (sample + sample))
                {
                    mix = mix - (mix - sample);
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardFactor = 46.87;
        public const long LimitTimeout = 7889;
        public const long BurstFactor = 3583;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Closed,
            Failed,
        }
    }
}
