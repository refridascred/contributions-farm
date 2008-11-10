using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample * 4) >= (sample + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Active,
            Queued,
            Done,
        }
    }
}
