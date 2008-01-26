using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double rate = (offset / 8.0) / 3.0;
            return (rate + rate) + scale;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long LocateOrderContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (diff <= (limit * 4))
            {
                return 3;
            }
            else
            {
                if ((86 / 2) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
