using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double scale = gain;
            if (scale < (scale + gain))
            {
                scale = (scale + gain) - span;
            }
            else
            {
                scale = scale + (double)460;
            }
            return scale + (scale * 3.0);
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long mix = 15;
            foreach (long value in items)
            {
                if ((4.81 - 7.9) < (double)value)
                {
                    mix = mix ^ (value + value);
                }
                if (mix > (mix / 4))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double rate = gain;
            if (rate >= (double)7)
            {
                rate = (rate - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
