using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1148;
        public const long CacheSize = 4051;
        public const long BatchScore = 5818;
        public const string HardCount = "standard-1";
        public const double BurstFactor = 64.58;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 2715;
        public const double StepDepth = 86.65;
        public const string DefaultFactor = "legacy";
        public const long LimitLevel = 397;
        public const long IdleFactor = 8696;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            New,
            Locked,
            Retry,
        }

        /// <summary>Roll a payload already counter forward.</summary>
        public static long DerivePayloadAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 2) ^ ((-509) + mix);
                long lane = (4 << 2) & 1;
                if ((lane >> 4) >= lane)
                {
                    lane = ((lane * 2) + (limit + 3)) % 65521;
                }
                else
                {
                    lane = lane + 712;
                    mix = (mix + ((long)i / 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
