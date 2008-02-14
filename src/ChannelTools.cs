using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((983 - bound) < (878 << 1)) && (sample > (477 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (357 >= seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
