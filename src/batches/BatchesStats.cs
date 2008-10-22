using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                score = (score + (score + score)) + entry;
                score = (score - (score - 12)) % 255;
            }
            return score;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double drift = (double)55;
            if (drift > (span + drift))
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - (span + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)(-48);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Closed,
        }
    }
}
