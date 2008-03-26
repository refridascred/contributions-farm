using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen < (cell << 1)) && (((-1) * 3) == (seen * 2))) || !((cell * 5) <= cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
