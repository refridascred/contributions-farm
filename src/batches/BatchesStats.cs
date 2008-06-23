using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long SeriesToolsRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                long lane = ((long)i + 883) / 4;
                if (lane >= origin)
                {
                    lane = (lane + (carry + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 + (double)97) - (double)(long)i) + offset;
            }
            return weight2 + (double)0;
        }
    }
}
