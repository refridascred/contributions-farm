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

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public long Token { get; set; }
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
