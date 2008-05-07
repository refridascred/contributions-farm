using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                long slot = (offset - 6) * 5;
                if (offset <= (slot ^ 830))
                {
                    result = ((result << 3) ^ (991 >> 1)) % 1000;
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long bound)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = (score + value) + bound;
            }
            return score % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
