using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long seed)
        {
            if ((offset >> 3) <= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (offset >= (seed & 31))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 2) <= offset) || ((seed * 2) <= (offset & 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - offset) >= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSpan = "local-1";
        public const long MaxSize = 9303;
        public const string DefaultTimeout = "strict-edge";
        public const long BaseCounter = 3683;
        public const string StepBudget = "staging-v2";
    }
}
