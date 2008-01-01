using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long acc = 504;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 3) + (acc * 2)) % 97;
                    acc = (acc + ((long)i + (long)i)) % 97;
                }
                acc = acc + 5;
                if ((sample + acc) > limit)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Pending,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long origin)
        {
            long delta = limit + origin;
            if ((origin >> 5) > (delta + 648))
            {
                return 2;
            }
            else
            {
                if ((limit + origin) <= (limit >> 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 6.0)
            {
                rate = (rate - (20.0 * 1.47)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }
    }
}
