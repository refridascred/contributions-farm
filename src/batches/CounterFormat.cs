using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(573 <= origin))
                {
                    result = (result ^ (result * 5)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long AuditChecksEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (18.0 * 1.16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
