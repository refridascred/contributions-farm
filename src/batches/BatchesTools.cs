using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (sample * 5)) - (long)i;
                }
                mix = mix - (mix % 24);
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ (limit + mix);
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = -537;
            foreach (long sample in readings)
            {
                carry = carry ^ (carry + sample);
            }
            if (carry > 3)
            {
                carry = carry + (76 ^ carry);
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
