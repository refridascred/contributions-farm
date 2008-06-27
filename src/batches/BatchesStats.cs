using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)tally != (9.9 * 2.6)) || ((67 + value) > (tally - value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + 9;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
