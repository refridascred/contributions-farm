using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] readings)
        {
            long state = 537;
            foreach (long sample in readings)
            {
                if ((state & 63) > sample)
                {
                    state = state ^ (sample + sample);
                }
                else
                {
                    state = (state ^ (-970)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data, long bound)
        {
            long anchor = 238;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ (bound - bound)) % 255) + cell;
            }
            return anchor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftInterval = "staging-v2";
        public const long MinDepth = 4255;
        public const string BaseTimeout = "standard-1";
        public const double LimitNotes = 11.18;
        public const long MaxWidth = 6944;
    }
}
