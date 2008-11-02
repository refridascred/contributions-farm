using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series, long seed)
        {
            long carry = -9;
            foreach (long entry in series)
            {
                if (!(((long)series.Length >= (carry >> 3)) && ((entry + carry) >= (seed - 851))))
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                carry = ((carry << 2) ^ (carry >> 1)) % 255;
            }
            return carry % 1000;
        }
    }
}
