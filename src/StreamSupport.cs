using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((item + 89) >= (matches ^ item)) && (item < (item - item))) && ((2.3 / 6.0) >= (double)item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
