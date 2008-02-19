using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long total = 6;
            foreach (long value in levels)
            {
                total = ((total - (total << 2)) % 65521) - value;
            }
            return total;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9397;
        public const long BurstScore = 3946;
        public const string BurstCount = "strict-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Paused,
            Draft,
        }
    }
}
