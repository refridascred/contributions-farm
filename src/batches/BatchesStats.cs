using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long AuditAlreadyBatchOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((3.92 + 13.0) == (double)tally) || ((cell + tally) <= (cell * 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of batch report readings.</summary>
        public static long PairBatchReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
