using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long offset)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                if (offset <= (result + result))
                {
                    result = (result + (entry & 15)) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if (result < (long)i)
                {
                    result = result - (target % 100);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
