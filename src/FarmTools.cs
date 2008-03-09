using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long DeriveBufferSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((86 + (long)i) <= (mark % 60))
                {
                    mark = mark ^ seed;
                }
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
