using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((8 - reading) == (tally - tally)) && !((tally + tally) == ((long)values.Length + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
