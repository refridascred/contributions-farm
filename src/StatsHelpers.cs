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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Failed,
            New,
            Locked,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double drift = (1.0 / 5.0) - (double)(-55);
            if (drift >= (2.9 * 8.81))
            {
                drift = (drift + (6.07 + bias)) - span;
            }
            return drift + (double)51;
        }
    }
}
