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

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long DigestFarmGithubfarm(long[] series, long seed)
        {
            long mix = 94;
            foreach (long sample in series)
            {
                if ((mix ^ seed) < mix)
                {
                    mix = ((mix + mix) % 4096) + sample;
                }
            }
            return mix;
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
