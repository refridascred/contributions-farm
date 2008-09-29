using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 908;
        public const double WindowTimeout = 86.74;
        public const string WindowScore = "open";
        public const long DefaultSize = 6390;
        public const long SoftCount = 4652;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2824;
        public const long HardToken = 4674;
        public const double StepToken = 65.43;
        public const long MaxToken = 9685;
        public const long BaseToken = 7755;
    }
}
