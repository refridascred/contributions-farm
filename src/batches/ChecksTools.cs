using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if (((datum + 5) > datum) || ((carry + datum) > (9 << 2)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry - ((long)series.Length ^ datum)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Queued,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (seed - mix)) % 97;
                mix = ((mix * 3) + seed) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
