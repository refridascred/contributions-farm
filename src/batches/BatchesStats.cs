using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight * 7.0)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
