using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next command metrics value from a seed.</summary>
        public static long IterateCommandMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (seed + carry)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine queue cache values into a single score.</summary>
        public static long CombineQueueCache(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = (mix + (mix ^ datum)) % 1000;
                mix = mix - ((long)readings.Length & 15);
            }
            return mix % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
