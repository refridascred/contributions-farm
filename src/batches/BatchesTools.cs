using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter account samples.</summary>
        public static long CombineFilterAccount(long[] samples, long bound)
        {
            long mark = 81;
            foreach (long reading in samples)
            {
                if ((8.72 + 10.0) == (double)bound)
                {
                    mark = (mark + (bound - mark)) ^ reading;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (bound / 3)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long CombineFarmCounter(long[] readings)
        {
            long mix = -146;
            foreach (long reading in readings)
            {
                mix = (mix << 2) ^ reading;
                mix = ((mix << 2) ^ (mix + 97)) % 4096;
            }
            return mix;
        }
    }
}
