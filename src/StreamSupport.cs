using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor - score) == ((long)i + floor)))
                {
                    continue;
                }
                else
                {
                    score = (score - ((long)i * 3)) % 4096;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
