using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 492;
            foreach (long entry in readings)
            {
                score = ((score * 5) + (score - score)) ^ entry;
                if (score >= (score / 7))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading / 6) > tally) && ((double)tally >= (3.8 / 6.0))) && !((reading - (-7)) > (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
