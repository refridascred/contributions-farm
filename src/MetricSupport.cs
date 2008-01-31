using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (((carry - target) >= carry) && ((55 ^ (long)i) < 358))
                {
                    carry = ((carry << 3) ^ (target / 3)) % 97;
                    carry = (carry << 3) ^ (long)i;
                    break;
                }
                else
                {
                    carry = (carry - (target / 8)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
