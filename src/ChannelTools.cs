using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 5120;
        public const long SoftChecks = 8792;
        public const string StepChecks = "legacy";

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Active,
            Done,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long step)
        {
            if ((bound < (bound & 15)) || (bound >= step))
            {
                return 0;
            }
            else
            {
                if (((step + bound) <= (554 + 2)) || ((bound ^ step) > bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
