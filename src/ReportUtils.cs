using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long result = -832;
            foreach (long sample in items)
            {
                result = ((result ^ (sample % 24)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long score = 20;
            foreach (long sample in series)
            {
                score = (score + (7 - 79)) - sample;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Active,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (tally ^ (long)samples.Length))
                {
                    tally = ((tally + 1) + cell) - offset;
                }
            }
            return tally;
        }
    }
}
