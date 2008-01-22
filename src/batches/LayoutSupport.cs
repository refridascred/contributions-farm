using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long score = -3;
            foreach (long reading in levels)
            {
                if (((double)score < (double)reading) && ((4.01 * 11.0) == (double)reading))
                {
                    score = (score - reading) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = bias + floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (floor * 3.76)) - (double)(long)i;
            }
            return load + (load - load);
        }
    }
}
