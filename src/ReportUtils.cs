using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 6240;
        public const double CacheDepth = 2.51;
        public const string MaxSpan = "strict-edge";
        public const long HardBudget = 6121;
        public const long DefaultDepth = 7411;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double load = scale - 5.0;
            if (load >= (4.0 / 2.0))
            {
                load = load - (scale * 6.1);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (span * 12.0)) + (double)(long)i;
            }
            return load + (scale / 5.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRoute = 72.25;
        public const long WindowTimeout = 5751;
        public const long MaxRoute = 1551;
        public const string SoftBudget = "staging";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
