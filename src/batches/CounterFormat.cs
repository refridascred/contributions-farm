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

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items, long step)
        {
            long acc = 93;
            foreach (long reading in items)
            {
                acc = ((acc + (3 * 4)) - reading) - step;
            }
            if (acc > 194)
            {
                acc = ((acc * 4) + (acc + 132)) % 255;
            }
            return acc;
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
