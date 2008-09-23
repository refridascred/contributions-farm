using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Done,
            Active,
            Paused,
        }
    }
}
