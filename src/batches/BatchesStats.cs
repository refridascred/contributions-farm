using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (result - (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
