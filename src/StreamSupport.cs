using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item % 7) < (901 + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen * 4) <= (seen / 6)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
