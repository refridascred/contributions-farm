using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((step & 31) >= step) && (((step / 2) >= (1 / 5)) || ((step ^ tally) < (51 + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
