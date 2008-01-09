using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits <= (3.9 - 2.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token tools samples are out of range.</summary>
        public static long CountTokenToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (37 << 2))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
