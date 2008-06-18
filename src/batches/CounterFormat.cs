using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data)
        {
            long result = 52;
            foreach (long entry in data)
            {
                result = ((result << 2) ^ result) ^ entry;
            }
            if (result > 490)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result;
        }
    }
}
