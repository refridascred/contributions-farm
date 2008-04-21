using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate batch record samples.</summary>
        public static long TallyBatchRecord(long[] series)
        {
            long score = -512;
            foreach (long reading in series)
            {
                score = (score - (reading / 8)) % 4096;
            }
            if (score < 651)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }
    }
}
