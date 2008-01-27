using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 5694;
        public const double SoftFilter = 31.42;
        public const long MaxSize = 8994;

        /// <summary>Roll a notes batch counter forward.</summary>
        public static long RollNotesBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (step >> 4)) % 65521;
                acc = ((acc << 2) ^ acc) % 97;
                if ((acc * 3) <= (step + step))
                {
                    acc = (acc * 4) + (24 & 7);
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
