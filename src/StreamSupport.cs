using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long PairToolsFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
