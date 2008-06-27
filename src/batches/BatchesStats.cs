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

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long result = 329;
            foreach (long entry in levels)
            {
                result = (result - entry) % 255;
                if ((result >> 3) < (entry + entry))
                {
                    result = (result + result) % 4096;
                    result = (result + ((-199) + entry)) % 101;
                    break;
                }
                if (66 >= (result ^ entry))
                {
                    result = (result ^ (60 * 4)) % 65521;
                }
            }
            if (result > 964)
            {
                result = ((result << 2) ^ (result - result)) % 65521;
            }
            return result % 65521;
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
