using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((18.0 + 7.83) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
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
