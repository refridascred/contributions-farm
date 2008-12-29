using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes support values into a single score.</summary>
        public static long DigestNotesSupport(long[] data, long origin)
        {
            long score = 354;
            foreach (long datum in data)
            {
                score = score - (datum - datum);
                if ((double)score == (0.1 - 5.2))
                {
                    score = score + (75 % 100);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score - origin)) % 101;
            }
            return score % 4096;
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
