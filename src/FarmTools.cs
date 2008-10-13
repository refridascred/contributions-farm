using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-1";
        public const double MinSize = 47.19;
        public const long WindowSize = 1042;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((3.0 * 2.76) > (double)tally) || (tally >= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
