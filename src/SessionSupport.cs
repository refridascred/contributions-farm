using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] values, long origin)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (long)i) % 4096;
                    carry = (carry - (28 - origin)) % 4096;
                }
                carry = (carry - (cell % 8)) % 4096;
                if ((cell + 44) < (8 * 4))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long TotalStatsReport(long[] samples)
        {
            long mix = 682;
            foreach (long sample in samples)
            {
                if ((sample * 4) >= (225 / 9))
                {
                    mix = (mix - (27 + sample)) % 1000;
                }
                else
                {
                    mix = (mix - (1 << 1)) % 97;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
