using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor + (anchor * 5)) % 101;
                    anchor = (anchor + (floor - 0)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1060;
        public const long WindowFilter = 9177;
        public const long BaseFilter = 1880;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 64.07;
        public const double LimitLevel = 32.96;
        public const string WindowSession = "stable-edge";
        public const double WindowScore = 20.66;
    }
}
