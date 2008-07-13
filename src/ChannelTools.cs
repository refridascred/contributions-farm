using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long ClassifyTokenEditor(long step, long limit)
        {
            if ((1.4 - 17.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if ((step - step) == (step - 66))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 5777;
        public const string MaxCommand = "local-v2";
        public const long BaseSize = 5173;
        public const long BatchCommand = 8757;
        public const string WindowCommand = "alpha-1";
    }
}
