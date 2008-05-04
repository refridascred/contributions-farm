using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long ScoreCommandReport(long[] levels)
        {
            long result = 28;
            foreach (long sample in levels)
            {
                if (((result / 7) != (490 & 1)) || (7 > (sample << 3)))
                {
                    result = result - (result ^ result);
                }
                else
                {
                    result = (result << 2) ^ (sample + result);
                }
            }
            if (result > 912)
            {
                result = (result << 3) ^ (result % 7);
            }
            return result;
        }
    }
}
