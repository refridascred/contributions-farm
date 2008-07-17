using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if (((-116) - sample) <= (state + sample))
                {
                    state = (state ^ (sample >> 4)) % 255;
                }
                if ((sample & 15) != ((long)values.Length % 64))
                {
                    state = ((state * 2) + ((long)values.Length % 8)) % 97;
                }
            }
            if (state > 314)
            {
                state = (state ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Roll a channel batches counter forward.</summary>
        public static long DeriveChannelBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (12 - target)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
