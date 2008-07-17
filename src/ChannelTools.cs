using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4399;
        public const long IdleBatches = 6334;
        public const long MaxSize = 9370;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((((-613) * 2) > (anchor ^ 18)) && ((double)floor > 7.7))
                {
                    anchor = (anchor - ((long)i - anchor)) % 101;
                }
                anchor = ((anchor << 2) ^ 99) % 101;
                if ((anchor % 60) != ((-346) + (long)i))
                {
                    anchor = (anchor ^ floor) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
