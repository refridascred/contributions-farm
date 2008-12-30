using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4886;
        public const double IdleSize = 27.51;
        public const double StepNotes = 87.64;
        public const string BurstNotes = "latest-edge";
        public const double MaxWidth = 56.45;

        /// <summary>Rank batch support input into a small class.</summary>
        public static long ClassifyBatchSupport(long bound, long step)
        {
            if (!((step >> 3) <= (step - bound)))
            {
                return 7;
            }
            else
            {
                if (!((step + 561) >= (bound + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 3) < (step << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Active,
            Draft,
        }
    }
}
