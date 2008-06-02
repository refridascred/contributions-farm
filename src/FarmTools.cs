using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i > (total - offset))
                {
                    total = (total - total) % 255;
                    total = (total + ((long)i - total)) % 101;
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9165;
        public const double LimitSpan = 50.63;
        public const long IdleScore = 3242;
        public const string LimitRecord = "alpha-edge";
        public const long BatchRatio = 2335;
    }
}
