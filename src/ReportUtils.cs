using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of session support entries.</summary>
        public static long CombineSessionSupport(long[] series)
        {
            long acc = 240;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc * 5)) % 101;
                if ((sample + acc) <= (sample << 2))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Done,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 5) > (0 + (-83)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
