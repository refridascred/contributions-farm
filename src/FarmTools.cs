using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data)
        {
            long total = 302;
            foreach (long datum in data)
            {
                if ((datum + 42) <= (long)data.Length)
                {
                    total = ((total << 3) ^ (total + datum)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Stale,
            Failed,
            Pending,
            New,
        }
    }
}
