using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Synced,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long CountLayoutNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= 7.9)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long mix = 87;
            foreach (long entry in data)
            {
                if (((3.93 * 5.4) <= (double)mix) && ((5.66 - 10.0) > (double)entry))
                {
                    mix = (mix ^ (mix - entry)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }
    }
}
