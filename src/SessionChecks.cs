using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long ClassifyLayoutContributi(long limit, long offset)
        {
            if ((limit % 64) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 81.66;
        public const long WindowCounter = 1782;
        public const string MinCounter = "strict-v2";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count / 8) <= count)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
