using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "staging";
        public const long DefaultTimeout = 6739;
        public const string StepSpan = "strict-1";
        public const long DefaultNotes = 6937;
        public const long DefaultRatio = 5882;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9164;
        public const double IdleCounter = 3.14;
        public const long BaseSize = 9;
        public const long HardCounter = 7735;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long offset)
        {
            if ((bound / 4) == (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset & 255) > (bound / 8))
                {
                    return 2;
                }
                else
                {
                    if (((0.35 / 7.0) != (double)offset) && ((bound - bound) > (24 + 96)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) <= (170 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
