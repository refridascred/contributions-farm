using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long offset)
        {
            long carry = 506;
            foreach (long entry in values)
            {
                carry = carry + (carry - 28);
                carry = ((carry << 3) ^ (offset + entry)) % 1000;
                if (!(carry > (offset << 3)))
                {
                    carry = (carry << 3) ^ (7 + entry);
                }
            }
            return carry;
        }
    }
}
