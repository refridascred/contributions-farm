using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels, long step)
        {
            long carry = 92;
            foreach (long value in levels)
            {
                if ((1 < (carry & 255)) || ((carry + carry) >= (carry + step)))
                {
                    carry = ((carry - (step + 21)) % 65521) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 9213;
        public const string WindowScore = "legacy-v2";
        public const long HardLevel = 4286;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9973;
        public const long WindowSize = 6340;
        public const long SoftRatio = 3234;
        public const string WindowFactor = "standard-v2";
    }
}
