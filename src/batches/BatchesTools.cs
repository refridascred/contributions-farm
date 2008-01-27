using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a session layout pair into a bucket.</summary>
        public static long ClassifySessionLayout(long target, long step)
        {
            long lane = target ^ step;
            if ((target << 2) >= (target + target))
            {
                return 5;
            }
            else
            {
                if (((step * 3) < (step ^ target)) || ((5 ^ 37) >= (lane + step)))
                {
                    return 0;
                }
                else
                {
                    if (75 <= (step << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long SeekMetricsAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
