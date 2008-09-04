using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long carry = 37;
            foreach (long datum in readings)
            {
                carry = ((carry << 3) ^ datum) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                if (!((sample >> 5) <= (3 - 547)))
                {
                    result = result - (sample & 255);
                }
            }
            return result;
        }
    }
}
