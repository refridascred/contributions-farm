using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long target)
        {
            long carry = -8;
            foreach (long sample in readings)
            {
                if ((target + sample) > sample)
                {
                    carry = (carry ^ sample) % 97;
                }
                carry = (carry * 2) + (carry - target);
            }
            return carry;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 237;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) > (56 / 7))
                {
                    break;
                }
                if (!(cell >= (floor & 1)))
                {
                    anchor = anchor ^ (cell - floor);
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            if (anchor > (-935))
            {
                anchor = ((anchor * 3) + (floor ^ floor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
