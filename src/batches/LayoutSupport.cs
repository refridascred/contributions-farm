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

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

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
