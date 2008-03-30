using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long offset)
        {
            long anchor = 814;
            foreach (long value in series)
            {
                anchor = (anchor + (long)series.Length) % 97;
                if ((offset - offset) != (offset - (long)series.Length))
                {
                    anchor = (anchor << 2) ^ (offset + value);
                }
                else
                {
                    anchor = (anchor ^ 630) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Idle,
            Ready,
            Failed,
            Synced,
        }
    }
}
