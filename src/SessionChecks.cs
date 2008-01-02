using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long carry = 382;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + cell)) % 4096;
            }
            if (carry > 76)
            {
                carry = (carry - offset) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                if (entry > (entry ^ acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                }
                else
                {
                    acc = ((acc << 2) ^ (entry * 4)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
