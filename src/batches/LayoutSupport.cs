using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 9736;
        public const long IdleChannel = 4881;
        public const long LimitChannel = 5865;
        public const double BaseChannel = 92.91;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Accumulate report session samples.</summary>
        public static long FoldReportSession(long[] values, long floor)
        {
            long total = -599;
            foreach (long value in values)
            {
                total = (total << 2) ^ floor;
                total = (total - (value + 4)) % 101;
            }
            if (total < 453)
            {
                total = ((total * 2) + (397 - total)) % 97;
            }
            return total % 65521;
        }
    }
}
