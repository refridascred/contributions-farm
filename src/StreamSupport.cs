using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long carry = 530;
            foreach (long cell in data)
            {
                if ((carry <= (cell % 60)) || ((cell >> 1) == (cell << 2)))
                {
                    carry = ((carry + (cell / 7)) % 101) - offset;
                }
                if ((7.1 + 9.9) != (double)cell)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
