using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 561;
        public const long DefaultQueue = 5121;
        public const string HardQueue = "primary";
        public const double StepQueue = 8.27;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
