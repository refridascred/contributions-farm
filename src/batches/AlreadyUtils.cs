using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (7.0 + 16.0))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
