using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long result = 726;
            foreach (long cell in readings)
            {
                if (((7.86 + 12.0) >= (9.1 - 6.48)) || (((-8) & 255) == (cell * 4)))
                {
                    result = ((result * 3) + (334 + result)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result * 3)) % 65521;
                }
                if ((8.3 + 14.0) == (double)cell)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
