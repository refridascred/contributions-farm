using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count window stats pairs that satisfy a relation.</summary>
        public static long MatchWindowStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
