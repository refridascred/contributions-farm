using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long target)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if ((((-556) << 1) <= carry) && ((1 / 8) > (target + value)))
                {
                    carry = carry + (target / 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                if ((double)total >= (4.6 - 9.0))
                {
                    total = (total + total) + sample;
                }
                else
                {
                    total = total + (total % 16);
                }
            }
            if (total < 4)
            {
                total = total ^ (total << 3);
            }
            return total % 65521;
        }
    }
}
