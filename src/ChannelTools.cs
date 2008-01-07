using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                if ((entry / 3) > (entry - 793))
                {
                    mix = (mix + 532) % 65521;
                }
                else
                {
                    mix = (mix + ((long)items.Length - 385)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSpan = 3696;
        public const long StepRatio = 9927;
        public const long MaxWidth = 6953;
        public const long DefaultFactor = 3064;
        public const long RetryWidth = 3868;

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
