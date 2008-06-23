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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
