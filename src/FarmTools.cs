using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) >= target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((offset + offset) < (771 << 2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
