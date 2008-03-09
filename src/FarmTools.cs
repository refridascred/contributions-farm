using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a order cluster counter forward.</summary>
        public static long DeriveOrderCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mix = 526;
            foreach (long reading in readings)
            {
                mix = (mix + (origin + 70)) % 65521;
                mix = (mix + reading) % 101;
            }
            return mix;
        }

        /// <summary>Validate support batches readings against a bound.</summary>
        public static bool CheckSupportBatchesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
