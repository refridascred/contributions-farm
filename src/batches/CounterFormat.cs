using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((edge & 255) > edge)
            {
                return 4;
            }
            else
            {
                if ((16.0 / 7.0) < (double)edge)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a notes checks value against two limits.</summary>
        public static long ClassifyNotesChecks(long target, long target2)
        {
            long bound = target - target2;
            if ((double)target != (5.09 / 8.0))
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    if ((target % 60) <= (961 - 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - 716) < (target / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
