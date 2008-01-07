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

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 54.45;
        public const double MaxBudget = 63.77;
        public const long RetryFactor = 4828;
        public const string StepSession = "primary-1";

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
