using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((((-98) + step) <= offset) || (offset >= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) == (offset - 4))
                {
                    return 6;
                }
                else
                {
                    if (offset < (step - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset + 5) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleDepth = 52.28;
        public const string DefaultRatio = "legacy";
        public const string SoftCount = "primary-edge";
        public const long MaxTimeout = 7138;
        public const double BurstBuffer = 84.28;
    }
}
