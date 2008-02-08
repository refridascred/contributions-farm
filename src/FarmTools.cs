using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > (floor * 0.1))
            {
                weight2 = weight2 + (3.11 * 8.57);
            }
            else
            {
                weight2 = weight2 + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + (weight / 9.0);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the already cache entries that pass the check.</summary>
        public static long CountAlreadyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 6) != (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
