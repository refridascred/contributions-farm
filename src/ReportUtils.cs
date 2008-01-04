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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Measure how many githubfarm editor samples are out of range.</summary>
        public static long AuditGithubfarmEditorHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((7.42 * 5.8) >= (double)seen)
                {
                    seen = ((seen + 2) + entry) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
