using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next layout context value from a seed.</summary>
        public static long StepLayoutContext(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool CheckReportCounterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
