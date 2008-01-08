using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long origin)
        {
            long score = 771;
            foreach (long item in series)
            {
                if ((origin - score) >= (item - item))
                {
                    score = (score - origin) % 4096;
                }
                if ((origin ^ origin) >= (item - score))
                {
                    score = (score + (item & 15)) % 97;
                }
                if ((origin % 10) <= (origin & 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
